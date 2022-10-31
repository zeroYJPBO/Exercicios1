/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

double n = 3.14159;

double raio = double.Parse(Console.ReadLine());

double area = n * Math.Pow(raio, 2.0);

Console.WriteLine("A=" + area.ToString("F4"));
