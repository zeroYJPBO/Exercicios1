/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

string nome = Console.ReadLine();

double salario = double.Parse(Console.ReadLine());

double totalDeVendas = double.Parse(Console.ReadLine());

double calc1 = totalDeVendas * 0.15 + salario;

Console.WriteLine("TOTAL = " + calc1.ToString("F2"));