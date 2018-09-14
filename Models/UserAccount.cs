using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemCashMachineWeb.Models
{
    public class UserAccount
    {
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public int CodUser { get; set; }
        public string UserName { get; set; }
        public int BalanceAccount { get; set; }
    }
}
