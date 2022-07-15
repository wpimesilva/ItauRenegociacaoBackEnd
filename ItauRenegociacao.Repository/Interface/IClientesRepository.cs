using ItauRenegociacao.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Repository.Interface
{
    public interface IClientesRepository
    {
        //atualizarDadosContato(ClientesContatos clientesContatos);
        Clientes consultaCPF(string cpf);
        //Task Commit();
    }
}
