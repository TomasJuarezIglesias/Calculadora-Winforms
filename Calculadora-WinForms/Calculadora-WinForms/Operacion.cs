using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WinForms
{
    public abstract class Operacion
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }
        public abstract void Calcular();

        public void SetValores(bool isPrimerValor, double valor)
        {
            if (isPrimerValor)
            {
                Valor1 = valor;
            }
            else
            {
                Valor2 = valor;
            }
        }
        public void LimpiarValores() => Valor1 = Valor2 = Resultado = 0;
        protected void SetResultado() => Valor1 = Resultado;
    }
}
