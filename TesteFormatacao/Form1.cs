using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteFormatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recebe um texto e justifica ele com 80 colunas inserindo espaços em branco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String textoEntrada = entrada.Text.ToString();            
            Int32 quantidadeEspacosParaCompletar = 80 - textoEntrada.Length;
            Int32 tamanhoIninicial = 0;
            String textoTemporario = "";
            String textoParaComparacao = "";
            String textoSaida = "";
            Int32 tamanhoTextoTemporario = 0;
            Int32 strPos = 0;
            
            while (tamanhoIninicial < 80)
            {
                for (int varCont = 0; textoEntrada.Length > varCont; varCont++)
                {
                    textoParaComparacao = textoEntrada.Substring(varCont, 1);
                    strPos = textoEntrada.Length - varCont;
                    if (textoParaComparacao.ToString() == " ")
                        {
                            
                            tamanhoTextoTemporario = textoTemporario.Length + 1;
                            textoTemporario = textoTemporario.PadRight(tamanhoTextoTemporario) + textoParaComparacao;
                            textoSaida = textoTemporario + textoEntrada.Substring(varCont, strPos);
                           
                    
                        }
                        else
                        {
                            textoSaida = textoTemporario + textoEntrada.Substring(varCont, strPos);
                            textoTemporario = textoTemporario + textoParaComparacao;                        
                            

                        }
                   
                        tamanhoTextoTemporario = textoSaida.Length;
                        if (tamanhoTextoTemporario >= 80)
                        {                                                 
                            tamanhoIninicial = tamanhoTextoTemporario;
                            resultado.Text = textoSaida.ToString();
                            textBox1.Text = tamanhoTextoTemporario.ToString();
                            break;
                        }
                                            
                }
                
                textoEntrada = textoTemporario;
                textoTemporario = string.Empty;
                if (tamanhoIninicial > 80)
                {
                    resultado.Text = textoSaida.ToString();
                    textBox1.Text = tamanhoIninicial.ToString();
                    break;
                }
             
            }           
        }
    }
}
