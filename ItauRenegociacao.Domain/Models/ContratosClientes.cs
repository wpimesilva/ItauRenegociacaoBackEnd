using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Domain.Models
{
    [Table("ContratosClientes")]
    public class ContratosClientes
    {
        public string idContrato { get; set; }
       
        
        public Clientes cliente { get; set; }

        public DateTime? dataContratoOriginal { get; set; }

        public DateTime? dataInicioDivida { get; set; }

        public Double? valorContratoOriginal { get; set; }
        public Double? valorContratoAtualizado { get; set; }


    }
}
