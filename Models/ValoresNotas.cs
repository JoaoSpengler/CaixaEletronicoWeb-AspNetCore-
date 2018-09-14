using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SystemCashMachineWeb.Models
{
    public class ValoresNotas
    {
        public int N100 { get; set; }
        public int N50 { get; set; }
        public int N20 { get; set; }
        public int N10 { get; set; }
        public int N5 { get; set; }
        public int N2 { get; set; }
        public string Valid { get; set; }
        public int SaldoFinal { get; set; }
        public UserAccount User { get; set; }

        public int AtualizaSaldo(int deposito)
        {
            SaldoFinal += deposito;

            return SaldoFinal;
        }
    }
}
