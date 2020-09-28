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

        private void button1_Click(object sender, EventArgs e)
        {
            String strTexto = entrada.Text.ToString();
            
            Int32 tamFaltam = 76 - strTexto.Length;
            Int32 tamIninicial = 0;
            String aux_2 = "";
            String aux_comp = "";
            String aux_final = "";
            Int32 strTam = 0;
            Int32 strPos = 0;
            
            while (tamIninicial < 76)
            {
                for (int varCont = 0; strTexto.Length > varCont; varCont++)
                {
                    aux_comp = strTexto.Substring(varCont, 1);
                    strPos = strTexto.Length - varCont;
                    if (aux_comp.ToString() == " ")
                        {
                            
                            strTam = aux_2.Length + 1;
                            aux_2 = aux_2.PadRight(strTam) + aux_comp;
                            aux_final = aux_2 + strTexto.Substring(varCont, strPos);
                           
                    
                        }
                        else
                        {
                            aux_final = aux_2 + strTexto.Substring(varCont, strPos);
                            aux_2 = aux_2 + aux_comp;                        
                            

                        }
                   
                    strTam = aux_final.Length;
                    if (strTam >= 76)
                        {
                       
                        tamIninicial = strTam;
                        resultado.Text = aux_final.ToString();
                            textBox1.Text = strTam.ToString();
                            break;
                        }
                                            
                }
                
                strTexto = aux_2;
                aux_2 = "";
                if (tamIninicial > 76)
                {
                    resultado.Text = aux_final.ToString();
                    textBox1.Text = tamIninicial.ToString();
                    break;
                }
             
            }           
        }
    }
}
