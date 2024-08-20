using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_maiormenos
{
    public partial class frm_peso : Form
    {
        public frm_peso()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radMercurio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radVenus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radMarte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radJupiter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radSaturno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radUrano_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Executa a ação quando clica no botão calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pesoP, pesoT;

            bool verifPeso = double.TryParse(txtPeso.Text, out pesoT);

          

            // só executa se o usuario digitar um número
            if (verifPeso == true)
            {
                // verifica se o usuario digitou um peso com número positivo
                if (double.Parse(txtPeso.Text) > 0) {

                    // o programa só executa o código se o campo de texto onde o usuário digitar não estiver em branco 
                    if (string.IsNullOrEmpty(txtPeso.Text) == false)
                    {
                        // pesoT recebe o texto que foi digitado pelo usuário e converte em um double
                        pesoT = double.Parse(txtPeso.Text);


                        // verifica os Radios Buttions marcados e faz a conta de acordo com a "G" de cada planeta
                        if (radJupiter.Checked == true)
                        {
                            pesoP = pesoT * 2.64;
                            MessageBox.Show($"Seu peso em Júpiter é {Math.Round(pesoP, 0)}kg");
                        }
                        else if (radMercurio.Checked == true)
                        {
                            pesoP = pesoT * 0.37;
                            MessageBox.Show($"Seu peso em Mercúrio é {Math.Round(pesoP, 0)}kg");
                        }
                        else if (radVenus.Checked == true)
                        {
                            pesoP = pesoT * 0.88;
                            MessageBox.Show($"Seu peso em Venus é {Math.Round(pesoP, 0)}kg");
                        }
                        else if (radMarte.Checked == true)
                        {
                            pesoP = pesoT * 0.38;
                            MessageBox.Show($"Seu peso em Marte é {Math.Round(pesoP, 0)}kg");
                        }
                        else if (radSaturno.Checked == true)
                        {
                            pesoP = pesoT * 1.15;
                            MessageBox.Show($"Seu peso em Saturno é {Math.Round(pesoP, 0)}kg");
                        }
                        else if (radUrano.Checked == true)
                        {
                            pesoP = pesoT * 1.17;
                            MessageBox.Show($"Seu peso em Urano é {Math.Round(pesoP, 0)}kg");
                        }
                    }
                    
                }
                else
                {
                    // exibe a mensagem caso double.Parse(txtPeso.Text > 0 retorne falso
                    MessageBox.Show("Digite um valor positivo");
                }

            }
            else
            {
                //exibe a mensagem caso verifPeso == true retorne falso
                MessageBox.Show("Digite um valor numérico!");
            }
        }
    }
}
