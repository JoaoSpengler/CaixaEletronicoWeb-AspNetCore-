using Microsoft.AspNetCore.Mvc;

namespace CaixaEletronicoCode.Models
{
    public class NumeroSaque
    {
        public ActionResult Value { get; set;  }
    }

    public class ValoresNotas
    {
        public ListaNotas[] ListaFinal { get; set; }
    }

    public class ListaNotas
    {
        public int Notas { get; set; }
    }
}