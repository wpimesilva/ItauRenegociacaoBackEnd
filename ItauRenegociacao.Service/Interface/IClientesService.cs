using ItauRenegociacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Service.Interface
{
    public interface IClientesService
    {
        //Task<ClientesContatos> atualizarDadosContato(ClientesContatos clientesContatos);
        Clientes consultaCPF(string cpf);
    }
}
