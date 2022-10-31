/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

int X = int.Parse(Console.ReadLine());

double Y = double.Parse(Console.ReadLine());

double calc = X / Y;

Console.WriteLine(calc.ToString("F3") + " km/l");