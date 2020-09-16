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
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome da Cidade")]
        public string NomeCidade { get; set; }

        [Display(Description = "UF")]
        public int UF { get; set; }
    }
}
