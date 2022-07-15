using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ItauRenegociacao.Domain.Models;
using ItauRenegociacao.Service.Interface;
using System;
using System.Threading.Tasks;

namespace ItauRenegociacao.API.Controllers
{
    [ApiController]
    public class ContratosController : ControllerBase
    {
        private readonly IContratosService _contratosService;
        public ContratosController(IContratosService contratosService)
        {
            _contratosService = contratosService;
        }


        [HttpGet]
        [Route("api/contratos/retornaContratosCliente/{idCliente}")]
        public IActionResult retornaContratosCliente(string idCliente)
        {
            try
            {
                if (idCliente == null)
                {
                    return BadRequest("Cliente não informado");
                }
                var contratos = _contratosService.retornaContratosCliente(idCliente);
                if (contratos.cliente.idCliente != idCliente)
                {
                    return BadRequest("Não Há contratos para renegociação");
                }
                return Ok(contratos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("api/contratos/aplicarDescontoAVista/{idContrato}/{percentualDesconto}")]
        public IActionResult aplicarDescontoAVista(string idContrato, double percentualDesconto)
        {
            try
            {
                
                var contratos = _contratosService.aplicarDescontoAVista(idContrato, percentualDesconto);
                
                return Ok(contratos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/contratos/aplicarDescontoParcelado/{idContrato}/{percentualDesconto}/{numeroParcelas}")]
        public IActionResult aplicarDescontoParcelado(string idContrato, double percentualDesconto, int numeroParcelas)
        {
            try
            {

                var contratos = _contratosService.aplicarDescontoParcelado(idContrato, percentualDesconto, numeroParcelas);

                return Ok(contratos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }





    }
}
