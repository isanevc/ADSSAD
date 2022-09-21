using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones osuma = new Operaciones();
            osuma.N1 = double.Parse(textBox1.Text);
            osuma.N2 = double.Parse(textBox2.Text);
            textBox4.Text = osuma.N2.ToString();
            textBox3.Text = osuma.sumar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operaciones oresta = new Operaciones();
            oresta.N1 = double.Parse(textBox1.Text);
            oresta.N2 = double.Parse(textBox2.Text);
            textBox4.Text = oresta.N2.ToString();
            textBox3.Text = oresta.restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operaciones omultiplicar = new Operaciones();
            omultiplicar.N1 = double.Parse(textBox1.Text);
            omultiplicar.N2 = double.Parse(textBox2.Text);
            textBox4.Text = omultiplicar.N2.ToString();
            textBox3.Text = omultiplicar.multiplicar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operaciones odividir = new Operaciones();
            odividir.N1 = double.Parse(textBox1.Text);
            odividir.N2 = double.Parse(textBox2.Text);
            textBox4.Text = odividir.N2.ToString();
            textBox3.Text = odividir.dividir().ToString();
        }
    }
}
