using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CaixaEletronicoCode.Models;

namespace CaixaEletronicoCode.Controllers
{
    public class SaqueController : Controller
    {
        [HttpPost]
        public ActionResult Index(string ValorSaque)
        {
            var valorTest = ValorSaque;

            var sacando = new CaixaEletronicoCode.Models.NumeroSaque()
            {
                Value = CalculoTest(valorTest)
            };

            return View(sacando);
        }

        private ActionResult CalculoTest(string valorTest)
        {
            var testSaque = valorTest;

            //Calculo para mostrar as notas?
            int value = Convert.ToInt32(testSaque);

            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;

            if (value % 2 != 0 && value > 5)
            {
                value -= 5;
                nota5 += 1;
            }
            nota100 = value / 100;
            nota50 = (value % 100) / 50;
            nota20 = ((value % 100) % 50) / 20;
            nota10 = (((value % 100) % 50) % 20) / 10;
            nota5 = ((((value % 100) % 50) % 20) % 10) / 5;
            nota2 = (((((value % 100) % 50) % 20) % 10) % 5) / 2;
            
            var testModelo = new ValoresNotas()
            {

            };

            return View(testModelo);
        }
    }
}