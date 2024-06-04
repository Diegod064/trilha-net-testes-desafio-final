using Xunit;
using CalculadoraGeometrica.Models; // Importe o namespace onde está definida a classe CalculadoraCirculo

namespace CalculadoraGeometrica.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAreaCirculo()
        {
            // Arrange
            double raio = 5;
            double esperado = 78.54;
            var calculadora = new CalculadoraCirculo(); // Instancie um objeto da classe CalculadoraCirculo

            // Act
            double resultado = calculadora.CalcularArea(raio); // Chame o método de instância da classe CalculadoraCirculo

            // Assert
            Assert.Equal(esperado, resultado, 2);
        }

        [Fact]
        public void TestPerimetroCirculo()
        {
            // Arrange
            double raio = 5;
            double esperado = 31.42;
            var calculadora = new CalculadoraCirculo(); // Instancie um objeto da classe CalculadoraCirculo

            // Act
            double resultado = calculadora.CalcularPerimetro(raio); // Chame o método de instância da classe CalculadoraCirculo

            // Assert
            Assert.Equal(esperado, resultado, 2);
        }

        [Fact]
        public void TestDiametroCirculo()
        {
            // Arrange
            double raio = 5;
            double esperado = 10;
            var calculadora = new CalculadoraCirculo(); // Instancie um objeto da classe CalculadoraCirculo

            // Act
            double resultado = calculadora.CalcularDiametro(raio); // Chame o método de instância da classe CalculadoraCirculo

            // Assert
            Assert.Equal(esperado, resultado, 2);
        }
    }
}
