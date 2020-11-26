using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.Models.Entidades;

namespace Cadastro.Services
{
    public class EstadoService
    {
        public static List<Estado> GetEstados()
        {
            var listaEstados = new List<Estado>()
            {
                new Estado(){ EstadoSigla = "AC", EstadoNome = "Acre"},
                new Estado(){ EstadoSigla = "AL", EstadoNome = "Alagos"},
                new Estado(){ EstadoSigla = "AP", EstadoNome = "Ámapa"},
                new Estado(){ EstadoSigla = "AM", EstadoNome = "Amazonas"},
                new Estado(){ EstadoSigla = "BA", EstadoNome = "Bahia"},
                new Estado(){ EstadoSigla = "CE", EstadoNome = "Ceará"},
                new Estado(){ EstadoSigla = "DF", EstadoNome = "Distrito Federal"},
                new Estado(){ EstadoSigla = "ES", EstadoNome = "Espirito Santo"},
                new Estado(){ EstadoSigla = "GO", EstadoNome = "Goias"},
                new Estado(){ EstadoSigla = "MA", EstadoNome = "Maranhão"},
                new Estado(){ EstadoSigla = "MT", EstadoNome = "Mato Grosso"},
                new Estado(){ EstadoSigla = "MS", EstadoNome = "Mato Grosso do Sul"},
                new Estado(){ EstadoSigla = "MG", EstadoNome = "Minas Gerais"},
                new Estado(){ EstadoSigla = "PA", EstadoNome = "Pará"},
                new Estado(){ EstadoSigla = "PB", EstadoNome = "Paraíba"},
                new Estado(){ EstadoSigla = "PR", EstadoNome = "Parana"},
                new Estado(){ EstadoSigla = "PE", EstadoNome = "Pernambuco"},
                new Estado(){ EstadoSigla = "PI", EstadoNome = "Piauí"},
                new Estado(){ EstadoSigla = "RJ", EstadoNome = "Rio de Janeiro"},
                new Estado(){ EstadoSigla = "RN", EstadoNome = "Rio Grande do Norte"},
                new Estado(){ EstadoSigla = "RS", EstadoNome = "Rio Grande do Sul"},
                new Estado(){ EstadoSigla = "RO", EstadoNome = "Rondonia"},
                new Estado(){ EstadoSigla = "RR", EstadoNome = "Roraima"},
                new Estado(){ EstadoSigla = "SC", EstadoNome = "Santa Catarina"},
                new Estado(){ EstadoSigla = "SP", EstadoNome = "São Paulo"},
                new Estado(){ EstadoSigla = "SE", EstadoNome = "Sergipe"},
                new Estado(){ EstadoSigla = "TO", EstadoNome = "Tocantis"}
            };

            return listaEstados;
        }
    }
}
