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
    public class ClientesRepository : IClientesRepository
    {
        private readonly ItauRenegociacaoContext _ItauRenegociacaoContext;


        public Clientes clientePadrao = new Clientes
        {
            cpf = "37830664846",
            idCliente = "5c74bb2c-b2e1-40a0-af64-3a515e4bfb9e"
        };

        public ClientesRepository(ItauRenegociacaoContext ItauRenegociacaoContext)
        {
            _ItauRenegociacaoContext = ItauRenegociacaoContext;
        }

        //public atualizarDadosContato(ClientesContatos clientesContatos)
        //{
       //     _ItauRenegociacaoContext.clientesContatos.AddAsync(clientesContatos);
            
        //}

        

        public Clientes consultaCPF(string cpf)
        {
            return clientePadrao;
        }


        
    }
}
