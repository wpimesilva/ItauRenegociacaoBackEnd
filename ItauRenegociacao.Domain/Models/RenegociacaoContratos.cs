using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Domain.Models
{
    [Table("RenegociacaoContratos")]
    public class RenegociacaoContratos
    {
        public Guid idRenegociacaoContratos { get; set; }
       
        [Required]
        public ContratosClientes contrato { get; set; }

        public Renegociacao renegociacao { get; set; }



    }
}
