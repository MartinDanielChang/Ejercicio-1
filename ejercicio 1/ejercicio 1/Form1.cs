using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            
            if (txtNumero.Text == "")
            {
                errorProvider1.SetError(txtNumero, "Ingrese un valor");
                return;
            }
            if (Convert.ToDecimal(txtNumero.Text) - Convert.ToInt32(txtNumero.Text) != 0)
            {
                errorProvider1.SetError(txtNumero, "Ingrese un numero entero");
                return;
            }
            errorProvider1.Clear();
            //Par o Impar
            string respuestaParImpar = ParImpar(Convert.ToInt32(txtNumero.Text));
            txtParImpar.Text = respuestaParImpar;

            //Positivo o negativo
            string respuestaNegativoPositivo = PositivoNegativo(Convert.ToInt32(txtNumero.Text));
            txtPositivoNegativo.Text = respuestaNegativoPositivo;
        }

        //Funcion Par Impar
        private string  ParImpar (int n1)
        {
            string resultadoParImpar = "";
            int numeroParImpar = Convert.ToInt32(txtNumero.Text);
            if (numeroParImpar % 2 == 0)
                resultadoParImpar = "El numero es Par";
            else 
                resultadoParImpar="El numero es Impar";

            return resultadoParImpar;
        }

        //Funcion Positivo o negativo
        private string PositivoNegativo  (int N1)
        {
            string resultadoPositivoNegativo = "";
            int numeroPositivioNegativo = Convert.ToInt32(txtNumero.Text);

            if (numeroPositivioNegativo >= 0)
                resultadoPositivoNegativo = "El numero es Positivo";
            else if(numeroPositivioNegativo <= 0)
                resultadoPositivoNegativo = "El numero es Negativo";

            return resultadoPositivoNegativo;
        }
    }
}
