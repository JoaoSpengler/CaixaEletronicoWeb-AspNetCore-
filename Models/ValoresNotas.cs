using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestUser.Models
{
    public class ValoresNotas
    {
        public int N100 { get; set; }
        public int N50 { get; set; }
        public int N20 { get; set; }
        public int N10 { get; set; }
        public int N5 { get; set; }
        public int N2 { get; set; }
        //Qtd de notas

        public string Valid { get; set; }
        //Validação do Saque

        public int SaldoFinal { get; set; }
        //Saldo a ser exibido e atualizado

        public int Deposito { get; set; }
        //Valor a ser depositado

        public int AtualizaSaldo(int deposito)
        {
            SaldoFinal += deposito;

            return SaldoFinal;
        }
    }
}
