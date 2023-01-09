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
        public double? PrimerValor { get; set; } 
        public double? SegundoValor { get; set; }
        public string Operacion { get; set; }
        public string SignoNegativo { get; set; } // Permite detectar cuando se desea un negativo

        // Se va concatendando los numeros junto con el signo para agregarlo a las properties
        // If hell but FUNCIONA XD :)
        public void AgregarValor(string valor)
        {
            if (Operacion == null)
            {
                if (valor == "-")
                {
                    SignoNegativo = "-";
                    return;
                }
                if (PrimerValor == null && SignoNegativo == "-") 
                {
                    PrimerValor = double.Parse($"{SignoNegativo}{valor}");
                    SignoNegativo = null;
                    return;
                }
                PrimerValor = double.Parse($"{PrimerValor}{valor}");
                return;
            }

            if (valor == "-")
            {
                SignoNegativo = "-";
                return;
            }
            if (SegundoValor == null && SignoNegativo == "-")
            {
                SegundoValor = double.Parse($"{SignoNegativo}{valor}");
                SignoNegativo = null;
                return;
            }
            SegundoValor = double.Parse($"{SegundoValor}{valor}");
        }

        //Agrega la operacion a realizar
        public void AgregarOperacion(string operacion)
        {
            Operacion = operacion;
        }

        // Se realiza la operacion para brindar el resultado deseado
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

        //Limpia las propiedades para ser utilizadas nuevamente
        public void LimpiarPropiedades()
        {
            PrimerValor = null;
            SegundoValor = null;
            Operacion = null;
        }
        

    }
}
