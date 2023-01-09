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
        Operaciones GestorOperaciones = new Operaciones();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("0");
            MostrarDatos("0");
        }

        private void BtnUno_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("1");
            MostrarDatos("1");
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("2");
            MostrarDatos("2");
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("3");
            MostrarDatos("3");
        }

        private void BtnCuatro_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("4");
            MostrarDatos("4");
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("5");
            MostrarDatos("5");
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("6");
            MostrarDatos("6");
        }

        private void BtnSiete_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("7");
            MostrarDatos("7");
        }

        private void BtnOcho_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("8");
            MostrarDatos("8");
        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            GestorOperaciones.AgregarValor("9");
            MostrarDatos("9");
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            MostrarResultado(GestorOperaciones.RealizarOperacion());
        }

        private void BtnMas_Click(object sender, EventArgs e)
        {
            bool canAdd = ValidacionOperacion();
            if (canAdd)
            {
                GestorOperaciones.AgregarOperacion("+");
                MostrarDatos("+");
                return;
            }
            MessageBox.Show("Ya has puesto una operacion a realizar");
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if (GestorOperaciones.PrimerValor == null || GestorOperaciones.SegundoValor == null)
            {
                GestorOperaciones.AgregarValor("-");
                MostrarDatos("-");
                return; 
            }
            bool canAdd = ValidacionOperacion();
            if (canAdd)
            {
                GestorOperaciones.AgregarOperacion("-");
                MostrarDatos("-");
                return;
            }
            MessageBox.Show("Ya has puesto una operacion a realizar");
        }

        private void BtnMultiplicacion_Click(object sender, EventArgs e)
        {
            bool canAdd = ValidacionOperacion();
            if (canAdd)
            {
                GestorOperaciones.AgregarOperacion("*");
                MostrarDatos("*");
                return;
            }
            MessageBox.Show("Ya has puesto una operacion a realizar");
        }

        private void BtnDIvision_Click(object sender, EventArgs e)
        {   
            bool canAdd = ValidacionOperacion();
            if (canAdd)
            {
                GestorOperaciones.AgregarOperacion("%");
                MostrarDatos("%");
                return;
            }
            MessageBox.Show("Ya has puesto una operacion a realizar");
        }

        // Muestra el dato al momento de tocar el boton
        public void MostrarDatos(string info)
        {
            LabelDatos.Text = $"{LabelDatos.Text}{info}";
        }

        // Muestra el resultado de la operacion
        public void MostrarResultado(string resultado)
        {
            LabelDatos.Text = resultado;
        }

        public void LimpiarDatos()
        {
            LabelDatos.Text = string.Empty;
        }

        // Evento que realiza la ejecucion de limpieza de datos
        private void BtnClean_Click(object sender, EventArgs e)
        {
            GestorOperaciones.LimpiarPropiedades();
            LimpiarDatos();
        }

        // Validacion para comprobar si ya existe una operacion
        public bool ValidacionOperacion()
        {
            if (GestorOperaciones.Operacion == null)
            {
                return true;
            }
            return false;
        }

        
    }
}
