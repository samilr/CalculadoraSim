using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimple
{
    public partial class CalculadoraInterfaz : Form
    {
        double uno, dos;
        string operador;

        public CalculadoraInterfaz()
        {
            InitializeComponent();
        }

        Clases.ClaseSuma OperacionSuma = new Clases.ClaseSuma();

        Clases.ClaseResta OperacionResta = new Clases.ClaseResta();

        Clases.ClaseMultiplicacion OperacionMultiplicar = new Clases.ClaseMultiplicacion();

        Clases.ClaseDivision OperacionDividir = new Clases.ClaseDivision();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            dos = double.Parse(tbxPatalla.Text);
            double sum, res, mul, div;

            switch (operador)
            {
                case "+":
                    sum = OperacionSuma.Sumar((uno), (dos));
                    tbxPatalla.Text = sum.ToString();
                    break;

                case "-":
                    res = OperacionResta.Restar((uno), (dos));
                    tbxPatalla.Text = res.ToString();
                    break;

                case "*":
                    mul = OperacionMultiplicar.Multiplicar((uno), (dos));
                    tbxPatalla.Text = mul.ToString();
                    break;
                        
                case "/":
                    div = OperacionDividir.Dividir((uno), (dos));
                    tbxPatalla.Text = div.ToString();
                    break;

                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbxPatalla.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operador = "-";
            uno = double.Parse(tbxPatalla.Text);
            tbxPatalla.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = "/";
            uno = double.Parse(tbxPatalla.Text);
            tbxPatalla.Clear();
        }

        private void Tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + "3";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            uno = double.Parse(tbxPatalla.Text);
            tbxPatalla.Clear();
        }

        private void btnMurtiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            uno = double.Parse(tbxPatalla.Text);
            tbxPatalla.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxPatalla.Text = tbxPatalla.Text + ".";
        }
    }
}
