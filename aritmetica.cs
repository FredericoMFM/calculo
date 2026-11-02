using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Tipo de conversão de temperatura a executar
    /// </summary>
    public enum ConversaoTemperatura
    {
        Nulo = 0,
        CelsiusFahrenheit,
        FahrenheitCelsius
    }


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

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 323);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -l;
        }
    }
}
