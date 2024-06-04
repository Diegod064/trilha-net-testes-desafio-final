using CalculadoraGeometrica.Models;

double raio = 5.0; // Definindo um raio inicial para o círculo

// Criando uma instância da CalculadoraCirculo
CalculadoraCirculo calculadora = new CalculadoraCirculo();

// Calculando e exibindo a área do círculo
double area = calculadora.CalcularArea(raio);
Console.WriteLine($"Área do círculo com raio {raio}: {area}");

// Calculando e exibindo o perímetro do círculo
double perimetro = calculadora.CalcularPerimetro(raio);
Console.WriteLine($"Perímetro do círculo com raio {raio}: {perimetro}");

// Calculando e exibindo o diâmetro do círculo
double diametro = calculadora.CalcularDiametro(raio);
Console.WriteLine($"Diâmetro do círculo com raio {raio}: {diametro}");