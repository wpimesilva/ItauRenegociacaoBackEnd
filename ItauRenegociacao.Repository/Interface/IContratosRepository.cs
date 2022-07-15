using ItauRenegociacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Repository.Interface
{
    public interface IContratosRepository
    {
        ContratosClientes retornaContratosCliente(string idCliente);
        ContratosClientes aplicarDescontoAVista(string idContrato, double percentualDesconto);
        ContratosClientes aplicarDescontoParcelado(string idContrato, double percentualDesconto, int numeroParcelas);

    }
}
