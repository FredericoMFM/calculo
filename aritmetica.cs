using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    
    /// <summary>
    /// operações aritméticas
    /// </summary>
    internal static class aritmetica
    {
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de dois numero.s</returns>
        public static int somar(int x, int y) {
            return x + y;
        }
        /// <summary>
        /// Operação subtração
        /// </summary>
        /// <returns>Returna o resultado da subtração de dois numeros.</returns>
        public static int subtrair(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}
