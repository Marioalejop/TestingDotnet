using Xunit;
using System;

namespace MiAppConsola.Tests
{

    public class CalculadoraTests
    {
        [Fact]
        public void Sumar_DosNumeros_RetornaResultadoEsperado()
        {
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;

            int resultado = calculadora.Sumar(a, b);

            Assert.Equal(8, resultado);

        }

        [Fact]
        public void Restar_DosNumeros_RetornaResultadoEsperado()
        {
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;

            int resultado = calculadora.Restar(a, b);

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicar_DosNumeros_RetornaResultadoEsperado()
        {
            var calculadora = new Calculadora();
            int a = 5;
            int b = 3;

            int resultado = calculadora.Multiplicar(a, b);

            Assert.Equal(15, resultado);
        }
        
        [Fact]
        public void Dividir_DosNumeros_RetornaResultadoEsperado()
        {
            var calculadora = new Calculadora();
            int a = 6;
            int b = 3;

            int resultado = calculadora.Dividir(a, b);

            Assert.Equal(2, resultado);
        }

    }
}