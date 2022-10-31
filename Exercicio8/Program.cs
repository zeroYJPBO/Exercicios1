/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

int numeroDoFuncionario = int.Parse(Console.ReadLine());

int numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine());

double valorDaHora = double.Parse(Console.ReadLine());

double salario = numeroDeHorasTrabalhadas * valorDaHora;

Console.WriteLine("NUMBER = " + numeroDoFuncionario);

Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));