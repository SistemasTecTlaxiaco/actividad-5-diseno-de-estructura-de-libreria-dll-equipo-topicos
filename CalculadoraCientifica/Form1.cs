using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
    
{
    public partial class Form1: Form
    {
        private double numero1 = 0;
        private string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;

        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            txtPantalla.Text += boton.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (txtPantalla.Text != "")
            {
                numero1 = Convert.ToDouble(txtPantalla.Text);
                operador = btnSuma.Text;
                txtPantalla.Clear();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void btnfraccion_Click(object sender, EventArgs e)
        {

        }

        private void btnBorarTodo_Click(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {

        }
    }
}
