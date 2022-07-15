using ItauRenegociacao.Domain.Models;
using ItauRenegociacao.Repository.Interface;
using ItauRenegociacao.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Service.Implementation
{
    public class ContratosService : IContratosService
    {
        private readonly IContratosRepository _contratosRepository;
        public ContratosService(IContratosRepository contratosRepository)
        {
            _contratosRepository = contratosRepository;
        }
                

        public ContratosClientes retornaContratosCliente(string idCliente)
        {
            return _contratosRepository.retornaContratosCliente(idCliente);
        }

        public ContratosClientes aplicarDescontoAVista(string idContrato, double percentualDesconto)
        {
            return _contratosRepository.aplicarDescontoAVista(idContrato, percentualDesconto);
        }

        public ContratosClientes aplicarDescontoParcelado(string idContrato, double percentualDesconto, int numeroParcelas)
        {
            return _contratosRepository.aplicarDescontoParcelado(idContrato, percentualDesconto, numeroParcelas);
        }




    }
}
