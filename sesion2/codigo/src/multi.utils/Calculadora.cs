using System;
using System.Collections.Generic;

namespace multi.utils
{
    public class Calculadora
    {
        public Calculadora()
        {
            
        }

        public int Multiplica(int a, int b){
            return a*b;
        }

        public int[] Tabla(int operando) {
            var resultados = new int[11];
            for (int i=0; i<11; i++) {
                resultados[i] = this.Multiplica(operando, i);
            }
            return resultados;
        }
    }
}
