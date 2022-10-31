/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

string[] vetD1 = Console.ReadLine().Split(' ');

string[] vetD2 = Console.ReadLine().Split(' ');

double x1 = double.Parse(vetD1[0]);
double y1 = double.Parse(vetD1[1]);

double x2 = double.Parse(vetD2[0]);
double y2 = double.Parse(vetD2[1]);

double calc = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

Console.WriteLine(calc.ToString("F4"));
