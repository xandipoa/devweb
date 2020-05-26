using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CADASTRO.Modelos.Entidades
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        public int codigo { get; set; }

        [Display(Description = "Nome da Cidade")]
        public string nome { get; set; }

        [Display(Description = "UF")]
        public string uf { get; set; }
    }
}
