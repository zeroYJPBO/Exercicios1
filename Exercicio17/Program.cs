/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

int tempoGasto = int.Parse(Console.ReadLine());

int velMedia = int.Parse(Console.ReadLine());

double progAuto = 12;

double calc1 = (tempoGasto * velMedia) / progAuto;

Console.WriteLine(calc1.ToString("F3"));