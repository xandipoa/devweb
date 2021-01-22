using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_DESAFIO.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        /// <summary>
        /// CPF
        /// </summary>
        [Key]
        [Required]
        [MaxLength(11)]
        public string Cpf { get; set; }
        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        /// <summary>
        /// Estado
        /// </summary>        
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }       
        
    }
}
