using System;
using Xunit;
using multi.utils;

namespace multi.tests
{
    public class TestLibreria
    {
        [Fact]
        public void MultiplicacionUnitaria()
        {
            var x = new Calculadora();
            var resultado = x.Multiplica(2,3);
            Assert.Equal(resultado, 2*3);
        }

        [Fact]
        public void TablaDeMultiplicar()
        {
            var x = new Calculadora();

            var resultado = x.Tabla(5);
            for(int i=0; i<11; i++){
                Assert.Equal(resultado[i], 5*i);
            }
        }

    }
}
