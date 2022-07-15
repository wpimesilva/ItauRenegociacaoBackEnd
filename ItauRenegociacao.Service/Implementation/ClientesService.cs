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
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _clientesRepository;
        public ClientesService(IClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }
        //public ClientesContatos atualizarDadosContato(ClientesContatos clientesContatos)
        //{
        //    clientesContatos.idContato = Guid.NewGuid();
        //    _clientesRepository.atualizarDadosContato(clientesContatos);
        //    return clientesContatos;
        //}

        

        public Clientes consultaCPF(string cpf)
        {
            return _clientesRepository.consultaCPF(cpf);
        }

       

       
    }
}
