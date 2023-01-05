using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WinForms
{
    internal class Division : Operacion
    {
        public override void Calcular()
        {
            if (Valor2 == 0)
                throw new DivideByZeroException("¿Que haces dividiendo por cero piscui?");

            Resultado = Valor1 / Valor2;
            SetResultado();
        }
    }
}
