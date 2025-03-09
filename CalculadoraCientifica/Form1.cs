using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraLib;

namespace CalculadoraCientifica
    
{
    public partial class calculadora: Form
    {
        private double numero1 = 0;
        private string operador = "";
        public calculadora()
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
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operador = btnResta.Text;
            txtPantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operador = btnMultiplicacion.Text;
            txtPantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operador = btnDivision.Text;
            txtPantalla.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                double numero = Convert.ToDouble(txtPantalla.Text);

                if (numero < 0)
                {
                    MessageBox.Show("No se puede calcular la raíz de un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double resultado = Math.Sqrt(numero);
                    txtPantalla.Text = resultado.ToString();
                }
            }
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operador = BtnPotencia.Text;
            txtPantalla.Clear();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operador = btnPorcentaje.Text;
            txtPantalla.Clear();
        }

        private void btnfraccion_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtPantalla.Text);
            operador = btnfraccion.Text;
            txtPantalla.Clear();
        }

        private void btnBorarTodo_Click(object sender, EventArgs e)
        {
            {
                txtPantalla.Clear();
                numero1 = 0;
                operador = "";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text != "")
            {
                double numero2 = Convert.ToDouble(txtPantalla.Text);
                double resultado = 0;

                try
                {
                    switch (operador)
                    {
                        case "+": resultado = Calculadora.Sumar(numero1, numero2); break;
                        case "-": resultado = Calculadora.Restar(numero1, numero2); break;
                        case "*": resultado = Calculadora.Multiplicar(numero1, numero2); break;
                        case "/": resultado = Calculadora.Dividir(numero1, numero2); break;
                        case "^": resultado = Calculadora.Potencia(numero1, numero2); break;
                        case "%": resultado = Calculadora.Porcentaje(numero1, numero2); break;
                        case "1/x": resultado = Calculadora.Fraccion(numero1, numero2); break;
                    }

                    txtPantalla.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
            {
                if (txtPantalla.Text == "")
                    txtPantalla.Text = "0."; // Si está vacío, empieza con "0."
                else
                    txtPantalla.Text += ".";
            }
        }
    }
}
