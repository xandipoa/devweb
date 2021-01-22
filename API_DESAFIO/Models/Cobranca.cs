using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_DESAFIO.Models
{
    [Table("Cobrancas")]
    public class Cobranca
    {
        [Key]
        public int CobrancaId { get; set; }

        /// <summary>
        /// Data de Vencimento
        /// </summary>
        [Required]
        public DateTime DtVencimeto { get; set; }

        /// <summary>
        /// CPF do Cliente
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string CpfCobranca { get; set; }

        /// <summary>
        /// Valor da cobrança
        /// </summary>
        [Required]
        public float Valor { get; set; }
    }
}

