using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ItauRenegociacao.Domain.Models;
using ItauRenegociacao.Service.Interface;
using System;
using System.Threading.Tasks;

namespace ItauRenegociacao.API.Controllers
{
    
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClientesService _clientesService;
        public ClientesController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }
        
        
        [HttpGet]
        [Route("api/clientes/consultaCPF/{cpf}")]
        public IActionResult consultaCPF(string cpf)
        {
            try
            {
                if (cpf == null)
                {
                    return BadRequest("Cliente não informado");
                }
                var clientes = _clientesService.consultaCPF(cpf);
                if (clientes.cpf != cpf)
                {
                    return BadRequest("Cliente não encontrado");
                }
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [HttpPost]
        [Route("api/clientes/atualizarDadosContato")]
        public IActionResult atualizarDadosContato(ClientesContatos clientesContatos)
        {
            try
            {
                //var clientesContatosInserido = _clientesService.atualizarDadosContato(clientesContatos);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}
