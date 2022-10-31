/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

string[] vetA = Console.ReadLine().Split(' ');

double A = double.Parse(vetA[0]);

double B = double.Parse(vetA[1]);

double C = double.Parse(vetA[2]);

double pi = 3.14159;

double areaTriangulo = (A * C) / 2;

double areaCirculo = pi * Math.Pow(C, 2.0);

double areaTrapezio = ((A + B) * C) / 2.0;

double areaQuadrado = Math.Pow(B, 2.0);

double areaRetangulo = A * B;

Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3"));

Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3"));

Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3"));

Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3"));

Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3"));