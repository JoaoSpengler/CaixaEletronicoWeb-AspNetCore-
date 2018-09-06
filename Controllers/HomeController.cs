using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CaixaEletronicoCode.Models;
using Test.Models;

namespace CaixaEletronicoCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ValorSaque, string ValorDeposita)
        {
            var saqueFinal = CalculaSaque(ValorSaque);
            //var depositoTotal = DepositaValor(ValorDeposita);
            return View();
        }
        
        public ActionResult DepositarValor(string ValorDeposita)
        {
            var deposito = ValorDeposita;
            int depositarValor = Convert.ToInt32(deposito);

            var depositando = new Deposito();

            var testDeposito = depositando.AcrescentaSaldo(depositarValor);

            return Json(testDeposito);
        }
    
        public ActionResult CalculaSaque(string ValorSaque)
        {
            var testSaque = ValorSaque;
            int value;

            if (testSaque == "")
            {
                value = 0;
            }
            else
            {
                value = Convert.ToInt32(testSaque);
            }

            int testAttValor;

            if (value == 0)
            {
                testAttValor = 0;
            }
            else
            {
                testAttValor = value;
            }

            //Apenas ilustrativo / para se ter uma noção se o deposito funciona
            var testeDeposito = new Deposito()
            {
                SaldoTotal = 10000
            };

            bool saqueAprovado = testeDeposito.VerificaSaldo(value);
            
            if (saqueAprovado == false)
            {
                //Mostrar ao usuario que o saldo é insuficiente.
                return View();
            }
            else
            {
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
                nota2 = (((((value % 100) % 50) % 20) % 10) / 2);

                value = (value - ((100 * nota100) + (50 * nota50) + (20 * nota20) + (10 * nota10) + (2 * nota2)));
                
                if (value == 0)
                {
                    var testModelo = new ValoresNotas()
                    {
                        N100 = nota100,
                        N50 = nota50,
                        N20 = nota20,
                        N10 = nota10,
                        N5 = nota5,
                        N2 = nota2,
                        SaldoFinal = testeDeposito.AtualizaSaldo(testAttValor)
                    };
                    //Retirar Valor do Saque do Saldo total e Atualizar na tela.
                    return View(testModelo);
                }
                else
                {
                    var testModelo = new ValoresNotas()
                    {
                        Valid = "O saque é inválido"
                    };
                    return View(testModelo);
                }
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            var viewModel = new Address()
            {
                Name = "Astarya",
                Street = "FarLand Street",
                City = "Eberron",
                State = "ESP",
                PostalCode = "98052-6399"
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
