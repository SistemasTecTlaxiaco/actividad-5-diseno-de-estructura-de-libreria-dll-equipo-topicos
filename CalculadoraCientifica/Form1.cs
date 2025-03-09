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

        }

        private void btnN2_Click(object sender, EventArgs e)
        {

        }

        private void btnN3_Click(object sender, EventArgs e)
        {

        }

        private void btnN4_Click(object sender, EventArgs e)
        {

        }

        private void btnN5_Click(object sender, EventArgs e)
        {

        }

        private void btnN6_Click(object sender, EventArgs e)
        {

        }

        private void btnN7_Click(object sender, EventArgs e)
        {

        }

        private void btnN8_Click(object sender, EventArgs e)
        {

        }

        private void btnN9_Click(object sender, EventArgs e)
        {

        }
    }
}
