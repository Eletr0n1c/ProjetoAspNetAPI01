using Microsoft.AspNetCore.Mvc;
using ProjetoAspNetAPI01.Data.Entities;
using ProjetoAspNetAPI01.Data.Interfaces;
using ProjetoAspNetAPI01.Services.Models;
using System;

namespace ProjetoAspNetAPI01.Services.Controllers
{
    [Route("api/[controller]")] //endereço do serviço /api/clientes
    [ApiController] //definindo que o controlador é do tipo API
    public class ClientesController : ControllerBase
    {
        //atributo para que possamos utilizar a camada de repositorio.
        private readonly IClienteRepository _clienteRepository;

        //método construtor para que nosso atributo possa ser inicializado
        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        //criando um método que permita realizar o cadastro de um cliente
        //serviço de API para cadastro de cliente
        [HttpPost]
        public IActionResult Post(ClienteCadastroModel model)
        {
            try
            {
                //Criando um objeto do tipo cliente
                var cliente = new Cliente();

                //Capturando os dados que a API receber através da model
                cliente.Nome = model.Nome;
                cliente.Email = model.Email;

                //cadastrando o cliente
                _clienteRepository.Inserir(cliente);

                //retornando mensagem de sucesso!
                return Ok($"Cliente {cliente.Nome}, cadastrado com sucesso! ");
            }
            catch (Exception e)
            {
                //retornando mensagem de erro!
                //HTTP 500 (Código de erro) -> INTERNAL SERVER ERROR
                return StatusCode(500, $"Ocorreu um erro: {e.Message}");
            }
        }
    }
}