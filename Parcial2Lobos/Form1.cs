using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {

            var boton = ((Button)sender);
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "";
            }

            txtResultado.Text += boton.Text;
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            
            Numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            txtResultado.Text = "0";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(txtResultado.Text);

            if (Operador == '+')
            {
                txtResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '-')
            {
                txtResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '*')
            {
                txtResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (Operador == '/')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (Numero1 / Numero2).ToString();
                    Numero1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por 0");
                }
                
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            txtResultado.Text = "0";
        }
    }
}