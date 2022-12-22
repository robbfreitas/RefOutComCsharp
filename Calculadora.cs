using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutComCsharp
{
    internal class Calculadora
    {
        // Ref vai apontar para a variável de tal escopo local
        public static void TriplicarRef(ref int x)
        {
            x *= 3;
        }
    }
}
