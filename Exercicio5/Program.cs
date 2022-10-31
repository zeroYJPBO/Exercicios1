/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

double A = double.Parse(Console.ReadLine());

double B = double.Parse(Console.ReadLine());

double calc = ((A * 3.5) + (B * 7.5)) / 11;

Console.WriteLine("MEDIA = " + calc.ToString("F5"));

