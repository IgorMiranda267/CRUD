using BikeVale.Data;
using BikeVale.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Savage.Data;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace Bike.Controllers
{
    public class AtendenteController : Controller
    {
        private readonly Contexto _context;

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BicicletasCadastradas()
        {
            return View("bikes-disponiveis-alugadas");
        }

        [HttpPost]
        public IActionResult CadastroCliente()
        {
            return View("ClientesCadastrados");
        }

        [HttpPost]
        public IActionResult AtendentesCadastrados()
        {
            return View("AtendentesCadastrados");
        }

        [HttpPost]
        public IActionResult HistoricoBikes()
        {
            return View("historicoAdim");
        }


        [HttpGet]
        public IActionResult cadastroBicicleta()
        {

            return View("cadastroBicicleta");
        }
        [HttpPost]
        public async Task<IActionResult> cadastroBicicletaPost(Bicicleta bike)
        {
            
            if (bike.Modelo != null)
            {
                if (ModelState.IsValid)
                {
                    using (MySqlConnection connection = new MySqlConnection("server=localhost;userid=teste@;password=123456;database=bancotp"))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand($"INSERT INTO bicicleta (Id_bicicleta, Modelo, Modalidade, Qtd_marchas, Status_emprestimo) VALUES ({bike.IdBicicleta},'{bike.Modelo}', '{bike.Modalidade}', {bike.QtdMarchas}, {bike.StatusEmprestimo});", connection))
                        {
                            bike.result = command.ExecuteNonQuery();
                        }
                    }
                }
            }
            return View("cadastroBicicleta", bike);
        }

        [HttpPost]
        public IActionResult cadastroClientePost(Cliente cliente)
        {
           
            var result = 0;
           
            var query = $"INSERT INTO endereco (Id_endereco, Numero, Rua, bairro, Cidade, cep) VALUES ({cliente.IdEndereco}, '{cliente.Numero}', '{cliente.Rua}', '{cliente.Bairro}', '{cliente.Cidade}', '{cliente.Cep}');"
                      + $"INSERT INTO telefone (Id_tel, DDD, Telefone) VALUES ( {cliente.IdTelefone}, {cliente.Ddd}, {cliente.Telefone});"
                      + $"INSERT INTO cliente (Id_cliente, Cpf, Nome, Sobrenome, Id_endereco,Id_tel,Email) VALUES ({cliente.IdCliente}, '{cliente.Cpf}', '{cliente.Nome}', '{cliente.Sobrenome}', {cliente.IdEndereco}, {cliente.IdTelefone}, '{cliente.Email}');";


            if (cliente.Nome != null)
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;userid=teste@;password=123456;database=bancotp"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        result = command.ExecuteNonQuery();
                    }
                }
            }
            return View("cadastroCliente");
        }


        [HttpPost]
        public IActionResult CadastroAtendentePost(Atendente atendente)
        {
           
            /*var result = 0;
           
            var query = $"INSERT INTO endereco (Id_endereco, Numero, Rua, bairro, Cidade, cep) VALUES ({cliente.IdEndereco}, '{cliente.Numero}', '{cliente.Rua}', '{cliente.Bairro}', '{cliente.Cidade}', '{cliente.Cep}');"
                      + $"INSERT INTO telefone (Id_tel, DDD, Telefone) VALUES ( {cliente.IdTelefone}, {cliente.Ddd}, {cliente.Telefone});"
                      + $"INSERT INTO cliente (Id_cliente, Cpf, Nome, Sobrenome, Id_endereco,Id_tel,Email) VALUES ({cliente.IdCliente}, '{cliente.Cpf}', '{cliente.Nome}', '{cliente.Sobrenome}', {cliente.IdEndereco}, {cliente.IdTelefone}, '{cliente.Email}');";


            if (cliente.Nome != null)
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;userid=teste@;password=123456;database=bancotp"))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        result = command.ExecuteNonQuery();
                    }
                }
            }*/
            return View("cadastroFuncionario");
        }



        // GET: AtendenteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AtendenteController/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: AtendenteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AtendenteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AtendenteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AtendenteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AtendenteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
