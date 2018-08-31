using Microsoft.AspNetCore.Mvc;

namespace CaixaEletronicoCode.Models
{
    public class ValoresNotas
    {
        public int n100 { get; set; }
        public int n50 { get; set; }
        public int n20 { get; set; }
        public int n10 { get; set; }
        public int n5 { get; set; }
        public int n2 { get; set; }
    }

    public class Test
    {
        public string TestNumber { get; set; }
    }
}