using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItauRenegociacao.Domain.Models
{
    [Table("ClientesContatos")]
    public class ClientesContatos
    {
        public Guid idContato { get; set; }

        [Required]
        public Clientes cliente { get; set; }

        [Required]
        [MaxLength(200)]
        public string nomeContato { get; set; }

        [Required]
        [MaxLength(200)]
        public string emailContato { get; set; }

        [Required]
        [MaxLength(200)]
        public string telefoneContato { get; set; }


    }
}
