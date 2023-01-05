using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WinForms
{
    public class Operaciones
    {
        private int? PrimerValor { get; set; } 
        private int? SegundoValor { get; set; }
        public string Operacion { get; set; }

        public void AgregarValor(int valor)
        {
            if (Operacion == null)
            {
                PrimerValor = int.Parse($"{PrimerValor}{valor}");
                return;
            }

            SegundoValor = int.Parse($"{SegundoValor}{valor}");
        }

        public void AgregarOperacion(string operacion)
        {
            Operacion = operacion;
        }

        public string RealizarOperacion()
        {
            if (Operacion == "+")
            {
                return $"{PrimerValor + SegundoValor}";
            }

            if (Operacion == "-")
            {
                return $"{PrimerValor - SegundoValor}";
            }

            if (Operacion == "*")
            {
                return $"{PrimerValor * SegundoValor}";
            }

            return $"{PrimerValor / SegundoValor}";
        }

        public void LimpiarPropiedades()
        {
            PrimerValor = null;
            SegundoValor = null;
            Operacion = null;
        }

    }
}
