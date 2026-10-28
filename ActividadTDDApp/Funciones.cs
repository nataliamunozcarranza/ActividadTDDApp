using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        private const long VALOR_INVALIDO = -1;
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
                return VALOR_INVALIDO;

            long factorial = 1;
            for (int i = 2; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        public static bool EsContrasenyaValida(string? contrasenya)
        {
            throw new NotImplementedException();
        }
    }
}
