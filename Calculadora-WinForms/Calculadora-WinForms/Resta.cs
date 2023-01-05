using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WinForms
{
    internal class Resta : Operacion
    {
        public override void Calcular()
        {
            Resultado = Valor1 - Valor2;
            SetResultado();
        }
    }
}
