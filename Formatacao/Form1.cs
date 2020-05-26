using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formatacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String strTexto = entrada.Text.ToString();
            Int32 tamMax = 76;
            Int32 tamFaltam = 76 - strTexto.Length;
            Int32 tamIninicial = 0;
            String aux_2 = "";
            String aux_comp = " ";
            Int32 strTam = 0;
            //Int32 pos = 0;
            while(tamIninicial < 76)
            {
                    for(int varCont = 0 ; strTexto.Length >= varCont; varCont++)
                    { 
                        
                         if( tamFaltam > 0 )
                         {
                            //aux_comp recebe o caracter da string para comparação
                            
                            aux_comp = strTexto.Substring(varCont, 1);
                                                   
                            //MessageBox.Show("Parte do texto : "+ aux_comp.ToString() + "  Na posição "+ varCont.ToString());
                            if (aux_comp.ToString() == " ")
                            {
                                //aux_1 = strTexto.Substring(0, varCont);
                                //MessageBox.Show("ENTROU!");
                                strTam = aux_2.Length + 2;
                                aux_2 = aux_2.PadRight(strTam); // + aux_comp;
                                tamFaltam = -tamFaltam;
                                tamIninicial = +tamIninicial;
                            //intMax = intMax - 1;
                            //aux_2 = aux_2 + aux_comp;
                            //resultado.Text = aux_2.ToString();
                            //Console.WriteLine(aux_2.ToString());
                            }
                            else 
                            {
                                aux_2 += aux_comp;
                                tamIninicial = +tamIninicial;
                            }
                            strTam = aux_2.Length;
                            if (strTam == 76)
                            {
                                strTam = strTexto.Length - varCont;
                                resultado.Text = aux_2 + strTexto.Substring(varCont, strTam);
                                break;
                            }
                            
                        
                          }
                          else
                          {
                            tamMax = varCont;
                            strTam = strTexto.Length - varCont;
                            resultado.Text = aux_2 + strTexto.Substring(varCont, strTam);                            
                            tamMax = 0;
                            break;
                          }       
                        
                     }
                    
                    MessageBox.Show("Controle do While Dentro : "+ tamIninicial.ToString());
                    strTam = aux_2.Length;
                    MessageBox.Show("TAMANHO DA STRING : " + strTam.ToString());
                    //Console.WriteLine(aux_2.ToString());
                    strTexto = aux_2;
                    aux_2 = "";
                    //tamIninicial = aux_2.Length;
                    if (tamIninicial == 76)
                    {
                        resultado.Text = aux_2 + strTexto.Substring(tamMax, strTam);
                        break;
                    }

            }
            strTam = strTexto.Length;
            MessageBox.Show("Contador do While Final : " + tamIninicial.ToString());
            MessageBox.Show("TAMANHO DA STRING : " + strTam.ToString());
            //resultado.Text = strTexto.ToString();
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
