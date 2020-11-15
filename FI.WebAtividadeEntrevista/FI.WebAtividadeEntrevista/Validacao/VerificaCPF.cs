using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Validacao
{
    public static class VerificaCPF
    {
        private static string stringConexao
        {
            get
            {
                ConnectionStringSettings conn = System.Configuration.ConfigurationManager.ConnectionStrings["BancoDeDados"];
                if (conn != null)
                    return conn.ConnectionString;
                else
                    return string.Empty;
            }
        }

        public static bool CPFExiste(string tabela, string cpf)
        {
            bool retornoCPF = false;
            bool retornouLinhas = false;
            SqlConnection conexao = null;
            SqlDataReader reader = null;
            try
            {
                conexao = new SqlConnection(stringConexao);
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                SqlCommand cmd = new SqlCommand("SELECT ID FROM " + tabela + " WHERE CPF = @CPF", conexao);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CPF";
                param.Value = cpf;
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();
                retornouLinhas = reader.Read();
                if (retornouLinhas)
                {
                    retornoCPF = true;
                }
            }
            finally
            {
                // Fecha o datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Fecha a conexão
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return retornoCPF;
        }
    }

}