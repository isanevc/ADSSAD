﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_1._3_Multiplicar_prp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el objeto
            Clmultiplicar omultiplicar = new Clmultiplicar();
            //El valor de la caja de texto1 lo convierte a entero y se lo asigna a la propiedad N1
            omultiplicar.N1 = int.Parse(textBox1.Text);
            //El valor de la caja de texto2 lo convierte a entero y se lo asigna a la propiedad N2
            omultiplicar.N2 = int.Parse(textBox2.Text);
            //textbox4 es para ver como funciona el get, es decir darle un valor que ya había sido asignado
            textBox4.Text = omultiplicar.N2.ToString();
            //La caja de texto3 es el resultado por lo que en este se realiza la operación
            textBox3.Text = omultiplicar.multiplicar().ToString();
        }
    }
}
