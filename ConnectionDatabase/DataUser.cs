using System.Data.SqlClient;
using System.Linq;
using SystemCashMachineWeb.Models;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace SystemCashMachineWeb.ConnectionDatabase
{
    public interface IUserRepository<T> where T : class
    {
        void Save(UserAccount Login);
        UserAccount FindUser(string Login);
        void Update(int Id, double AccountBalance);
    }

    public class UserRepository : IUserRepository<UserAccount>
    {
        private readonly string ConnectionString;
        protected IConfiguration _config;

        public UserRepository(IConfiguration config)
        {
            _config = config;
            ConnectionString = _config.GetConnectionString("DefaultConnection");
        }

        public void Save(UserAccount user)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var t = conn.BeginTransaction())
                {
                    conn.Execute(@"INSERT INTO [dbo].[UsersAccount]
											       ([LoginUser]
											       ,[PasswordUser]
                                                   ,[BalanceAccount]
                                                   ,[UserName])
									
										     VALUES
											       (@LoginUser
											       ,@PasswordUser
                                                   ,@BalanceAccount
                                                   ,@UserName)", new { user.LoginUser, user.PasswordUser, user.BalanceAccount, user.UserName }, transaction: t);
                    t.Commit();
                }
            }
        }

        public UserAccount FindUser(string LoginUser)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var t = conn.BeginTransaction())
                {
                    UserAccount result = conn.Query<UserAccount>(@"SELECT * FROM [dbo].[UsersAccount] WHERE [LoginUser] = @LoginUser", new { LoginUser }, transaction: t).SingleOrDefault();
                    return result;
                }
            }
        }

        public void Update(int CodUser, double BalanceAccount)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (var t = conn.BeginTransaction())
                {
                    conn.Execute(@"UPDATE [dbo].[UsersAccount] SET [BalanceAccount] = @BalanceAccount WHERE CodUser = @CodUser", new { BalanceAccount, CodUser }, transaction: t);
                    t.Commit();
                }
            }
        }
    }
}