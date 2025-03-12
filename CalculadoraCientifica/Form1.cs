using System;
using System.Windows.Forms;
using CalculadoraLib;

namespace CalculadoraCientifica
{
    public partial class calculadora : Form
    {
        private double numero1 = 0;
        private string operador = "";

        public calculadora()
        {
            InitializeComponent();
        }

        // Métodos de botones numéricos (0-9)
        private void btnN0_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN1_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN2_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN3_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN4_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN5_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN6_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN7_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN8_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }
        private void btnN9_Click(object sender, EventArgs e) { Button boton = sender as Button; txtPantalla.Text += boton.Text; }

        // Métodos para operaciones básicas
        private void btnSuma_Click(object sender, EventArgs e) { operador = btnSuma.Text; GuardarNumero(); }
        private void btnResta_Click(object sender, EventArgs e) { operador = btnResta.Text; GuardarNumero(); }
        private void btnMultiplicacion_Click(object sender, EventArgs e) { operador = btnMultiplicacion.Text; GuardarNumero(); }
        private void btnDivision_Click(object sender, EventArgs e) { operador = btnDivision.Text; GuardarNumero(); }

        // Método para guardar el número y limpiar la pantalla
        private void GuardarNumero()
        {
            if (txtPantalla.Text != "")
            {
                numero1 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Clear();
            }
        }

        // Método para la raíz cuadrada
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

        // Método para la potencia
        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            operador = BtnPotencia.Text;
            GuardarNumero();
        }

        // Método para calcular el porcentaje
        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            operador = btnPorcentaje.Text;
            GuardarNumero();
        }

        // Método para convertir decimal a fracción
        private string DecimalToFraction(double decimalNumber)
        {
            const double precision = 0.0001;
            int sign = Math.Sign(decimalNumber);
            decimalNumber = Math.Abs(decimalNumber);

            int integerPart = (int)decimalNumber;
            decimalNumber -= integerPart;

            if (decimalNumber < precision)
            {
                return $"{sign * integerPart}";
            }
            else if (1 - precision < decimalNumber)
            {
                return $"{sign * (integerPart + 1)}";
            }

            int lowerNumerator = 0;
            int lowerDenominator = 1;
            int upperNumerator = 1;
            int upperDenominator = 1;

            while (true)
            {
                int middleNumerator = lowerNumerator + upperNumerator;
                int middleDenominator = lowerDenominator + upperDenominator;

                if (middleDenominator * (decimalNumber + precision) < middleNumerator)
                {
                    upperNumerator = middleNumerator;
                    upperDenominator = middleDenominator;
                }
                else if (middleNumerator < (decimalNumber - precision) * middleDenominator)
                {
                    lowerNumerator = middleNumerator;
                    lowerDenominator = middleDenominator;
                }
                else
                {
                    return $"{sign * (integerPart * middleDenominator + middleNumerator)}/{middleDenominator}";
                }
            }
        }

        // Botón para convertir el número a fracción
        private void btnfraccion_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != "")
            {
                double decimalNumber = Convert.ToDouble(txtPantalla.Text);
                string fraction = DecimalToFraction(decimalNumber);
                txtPantalla.Text = fraction;
            }
        }

        // Método para borrar todo
        private void btnBorarTodo_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            numero1 = 0;
            operador = "";
        }

        // Método para el botón igual
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
                    }

                    txtPantalla.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para el punto decimal
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
            {
                if (txtPantalla.Text == "")
                    txtPantalla.Text = "0."; // Si está vacío, empieza con "0."
                else
                    txtPantalla.Text += ".";
            }
        }
    }
}
