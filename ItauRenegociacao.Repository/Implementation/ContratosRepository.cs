using Microsoft.EntityFrameworkCore;
using ItauRenegociacao.Domain.Models;
using ItauRenegociacao.Repository.Data;
using ItauRenegociacao.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Repository.Implementation
{
    public class ContratosRepository : IContratosRepository
    {
        private readonly ItauRenegociacaoContext _ItauRenegociacaoContext;

        

        public ContratosClientes contratoPadrao = new ContratosClientes
        {
            idContrato = "7b4ed2fd-8931-49d3-9639-0d317deaf895",
            dataContratoOriginal = DateTime.Now.AddDays(-300),
            dataInicioDivida = DateTime.Now.AddDays(-200),
            valorContratoOriginal = 5000,
            valorContratoAtualizado = 98000,
            cliente = new Clientes
            {
                cpf = "37830664846",
                idCliente = "5c74bb2c-b2e1-40a0-af64-3a515e4bfb9e"
            }
    };

        public ContratosRepository(ItauRenegociacaoContext ItauRenegociacaoContext)
        {
            _ItauRenegociacaoContext = ItauRenegociacaoContext;
        }

        public ContratosClientes retornaContratosCliente(string idCliente)
        {
            return contratoPadrao;
        }

        public ContratosClientes aplicarDescontoAVista(string idContrato, double percentualDesconto)
        {
            var contratoAVista = contratoPadrao;

            contratoAVista.valorContratoAtualizado = contratoAVista.valorContratoAtualizado - ((contratoAVista.valorContratoAtualizado * percentualDesconto) / 100);

            return contratoAVista;
        }

        public ContratosClientes aplicarDescontoParcelado(string idContrato, double percentualDesconto, int numeroParcelas)
        {
            var contratoAVista = contratoPadrao;

            contratoAVista.valorContratoAtualizado = (contratoAVista.valorContratoAtualizado - ((contratoAVista.valorContratoAtualizado * percentualDesconto) / 100))/numeroParcelas;

            return contratoAVista;
        }



    }
}
