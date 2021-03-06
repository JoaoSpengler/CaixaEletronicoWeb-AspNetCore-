﻿using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SystemCashMachineWeb.Models;
using SystemCashMachineWeb.ConnectionDatabase;

namespace SystemCashMachineWeb.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository<UserAccount> repo;

        public HomeController(IUserRepository<UserAccount> connections)
        {
            repo = connections;
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(string LoginUser, string PasswordUser)
        {
            var findUser = repo.FindUser(LoginUser);
            
            if (findUser == null)
            {
                @ViewData["LoginError"] = "User not found - Try another login";
                return View();
            }
            else if(findUser.LoginUser == LoginUser && findUser.PasswordUser == PasswordUser)
            {
                var user = new UserAccount
                {
                    LoginUser = findUser.LoginUser,
                    PasswordUser = findUser.PasswordUser,
                    CodUser = findUser.CodUser,
                    BalanceAccount = findUser.BalanceAccount,
                    UserName = findUser.UserName
                };
                var cashValue = new ValoresNotas();

                cashValue.User = user;
                HttpContext.Session.SetObjectAsJson("User", user);

                return RedirectToAction("Index");
            }
            else
            {
                ViewData["LoginError"] = "Incorrect Password";
                return View();
            }
        }

        public IActionResult LogOut()
        {
            var user = HttpContext.Session.GetObjectFromJson<UserAccount>("User");
           
            user = null;
            HttpContext.Session.SetObjectAsJson("User", user);

            return RedirectToAction("LoginPage");
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(string LoginUser, string UserNameId, string PasswordId, string PasswordConfirm)
        {
            var user = new UserAccount();
            var findUser = repo.FindUser(LoginUser);

            if(findUser != null)
            {
                ViewData["Error"] = "Email already registered";
                return View();
            }
            else
            {
                if (LoginUser == null || UserNameId.Length < 6)
                {
                    ViewData["Error"] = "Insert a User Name with minnimun of 6 caracters";
                }
                else if (PasswordId.Length < 5)
                {
                    ViewData["Error"] = "Password must be at least 8 characters";
                }
                else if (PasswordId != PasswordConfirm)
                {
                    ViewData["Error"] = "Password aren't the same";
                }
                else
                {
                    user = new UserAccount
                    {
                        LoginUser = LoginUser,
                        PasswordUser = PasswordId,
                        UserName = UserNameId,
                        BalanceAccount = 0
                    };
                    repo.Save(user);
                    return RedirectToAction("LoginPage");
                }

                return View(user);
            }
        }

        public IActionResult Index()
        {
            var user = HttpContext.Session.GetObjectFromJson<UserAccount>("User");

            var testModelo = new ValoresNotas()
            {
                N100 = 0,
                N50 = 0,
                N20 = 0,
                N10 = 0,
                N5 = 0,
                N2 = 0,
                SaldoFinal = user.BalanceAccount,
                Valid = "Aguardando Transações!"
            };

            return View(testModelo);
        }

        public JsonResult DepositaValor(string valorDep)
        {
            //Criar e gerenciar a sessão com os dados do Saldo!

            var deposito = valorDep;
            int depositarValor = Convert.ToInt32(deposito);

            var user = HttpContext.Session.GetObjectFromJson<UserAccount>("User");
            
            //Refazer lógica para acrescentar os dados do DB
            
            var depositoSaque = new ValoresNotas
            {
                SaldoFinal = user.BalanceAccount + depositarValor
            };

            user.BalanceAccount = depositoSaque.SaldoFinal;
            
            HttpContext.Session.SetObjectAsJson("Saldo", depositoSaque.SaldoFinal);
            repo.Update(user.CodUser, depositoSaque.SaldoFinal);
            HttpContext.Session.SetObjectAsJson("User", user);

            return Json(depositoSaque);
        }

        [HttpPost]
        public JsonResult CalculaSaque(string valorSaq)
        {
            var testSaque = valorSaq;
            var user = HttpContext.Session.GetObjectFromJson<UserAccount>("User");

            int value;

            if (testSaque == "" || testSaque == null)
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


            bool saqueAprovado;

            if (value > user.BalanceAccount)
            {
                saqueAprovado = false;
            }
            else
            {
                saqueAprovado = true;
            }

            if (saqueAprovado == false)
            {
                //Mostrar ao usuario que o saldo é insuficiente.
                var saldoInsuficiente = new ValoresNotas()
                {
                    SaldoFinal = user.BalanceAccount,
                    Valid = "Saldo Insuficiente"
                };
                return Json(saldoInsuficiente);
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
                        SaldoFinal = user.BalanceAccount - testAttValor,
                        Valid = "Saque efetuado com sucesso"
                    };
                    user.BalanceAccount = testModelo.SaldoFinal;

                    HttpContext.Session.SetObjectAsJson("Saldo", testModelo.SaldoFinal);
                    repo.Update(user.CodUser, testModelo.SaldoFinal);
                    HttpContext.Session.SetObjectAsJson("User", user);

                    return Json(testModelo);
                }
                else
                {
                    var testModelo = new ValoresNotas()
                    {
                        SaldoFinal = user.BalanceAccount,
                        Valid = "Valor inválido, notas indisponiveis"
                    };
                    return Json(testModelo);
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
