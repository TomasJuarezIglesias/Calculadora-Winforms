using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_WinForms
{
    public partial class Form1 : Form
    {
        Operacion operacion;
        double valorActual;
        bool primerValor;
        public Form1()
        {
            InitializeComponent();
            valorActual = 0;
        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            MostrarDatos("0");
            ActualizarValor();
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            MostrarDatos("1");
            ActualizarValor();
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            MostrarDatos("2");
            ActualizarValor();
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            MostrarDatos("3");
            ActualizarValor();
        }

        private void BtnCuatro_Click(object sender, EventArgs e)
        {
            MostrarDatos("4");
            ActualizarValor();
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            MostrarDatos("5");
            ActualizarValor();
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            MostrarDatos("6");
            ActualizarValor();
        }

        private void BtnSiete_Click(object sender, EventArgs e)
        {
            MostrarDatos("7");
            ActualizarValor();
        }

        private void BtnOcho_Click(object sender, EventArgs e)
        {
            MostrarDatos("8");
            ActualizarValor();
        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            MostrarDatos("9");
            ActualizarValor();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionOperacion();
                ActualizarValor();
                operacion.SetValores(primerValor, valorActual);
                operacion.Calcular();
                LabelDatos.Text = operacion.Resultado.ToString();
            }
            catch(DivideByZeroException zex)
            {
                MessageBox.Show(zex.Message, "Epa",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                operacion.LimpiarValores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Epa", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            CrearOperacion(new Suma());
            LabelDatos.Text = "0";
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            CrearOperacion(new Resta());
            LabelDatos.Text = "0";
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            CrearOperacion(new Multiplicacion());
            LabelDatos.Text = "0";
        }

        private void BtnDIvision_Click(object sender, EventArgs e)
        {
            CrearOperacion(new Division());
            LabelDatos.Text = "0";
        }

        public void ActualizarValor()
        {
            primerValor = false;
            if (operacion == null)
            {
                primerValor = true;
            }
            valorActual = double.Parse(LabelDatos.Text);
        }
        public void MostrarDatos(string info)
        {
            if (int.Parse(LabelDatos.Text) == 0)
            {
                LabelDatos.Text = info;
            }
            else
            {
                LabelDatos.Text = $"{LabelDatos.Text}{info}";
            }
        }


        public void LimpiarDatos()
        {
            operacion.LimpiarValores();
            LabelDatos.Text = "0";
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        public void ValidacionOperacion()
        {
            if (operacion == null)
            {
                throw new Exception("Tenes que usar los botoncitos para las operaciones piscui");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelDatos.Text = "0";
        }
        private void CrearOperacion(Operacion nuevaOperacion)
        {
            if (operacion == null)
            {
                operacion = nuevaOperacion;
            }
            if (operacion != null && operacion.GetType() != nuevaOperacion.GetType())
            {
                double valor1 = operacion.Valor1;
                operacion = nuevaOperacion;
                operacion.Valor1 = valor1;
                operacion.Valor2 = valorActual;
                primerValor = false;
            }
            operacion.SetValores(primerValor, valorActual);
        }
    }
}
