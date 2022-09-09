using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double suma = numero1 + numero2;
            label3.Text = "La suma es: " + suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resta = numero1 - numero2;
            label3.Text = "La resta es: " + resta.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double multiplicacion = numero1 * numero2;
            label3.Text = "La multiplicacion es: " + multiplicacion.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double division = numero1 / numero2;
            label3.Text = "La division es: " + division.ToString();
        }
    }
}
