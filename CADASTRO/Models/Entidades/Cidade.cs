using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Models.Entidades
{
    [Table("Cidade")]
    public class Cidade
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome da Cidade")]
        public string NomeCidade { get; set; }

        [Display(Description = "UF")]
        public string UF { get; set; }
    }

    public class Estado
    {
        public string EstadoNome { get; set; }
        public string EstadoSigla { get; set; }
    }
}
