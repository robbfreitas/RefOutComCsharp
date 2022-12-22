using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutComCsharp
{
    internal class CalculadoraOut
    {

        public static void TriplicarOut(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
