using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Domain.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        public string idCliente { get; set; }
        public string cpf { get; set; }

    }
}
