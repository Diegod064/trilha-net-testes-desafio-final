using Xunit;
using CalculadoraGeometrica.Models; // Importe o namespace onde está definida a classe CalculadoraCirculo

namespace CalculadoraGeometrica.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 78.54)] // Raio: 5, Área esperada: 78.54
        [InlineData(10, 314.16)] // Raio: 10, Área esperada: 314.16
        public void TestAreaCirculo(double raio, double esperado)
        {
            var calculadora = new CalculadoraCirculo();
            double resultado = calculadora.CalcularArea(raio);
            Assert.Equal(esperado, resultado, 2);
        }

        [Theory]
        [InlineData(5, 31.42)] // Raio: 5, Perímetro esperado: 31.42
        [InlineData(10, 62.83)] // Raio: 10, Perímetro esperado: 62.83
        public void TestPerimetroCirculo(double raio, double esperado)
        {
            var calculadora = new CalculadoraCirculo();
            double resultado = calculadora.CalcularPerimetro(raio);
            Assert.Equal(esperado, resultado, 2);
        }

        [Theory]
        [InlineData(5, 10)] // Raio: 5, Diâmetro esperado: 10
        [InlineData(10, 20)] // Raio: 10, Diâmetro esperado: 20
        public void TestDiametroCirculo(double raio, double esperado)
        {
            var calculadora = new CalculadoraCirculo();
            double resultado = calculadora.CalcularDiametro(raio);
            Assert.Equal(esperado, resultado, 2);
        }
    }
}
