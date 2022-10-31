/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

string[] vetPeca1 = Console.ReadLine().Split(' ');

string[] vetPeca2 = Console.ReadLine().Split(' ');

int codPeca1 = int.Parse(vetPeca1[0]);

int nPeca1 = int.Parse(vetPeca1[1]);

double valorPecaUnitaria1 = double.Parse(vetPeca1[2]);

int codPeca2 = int.Parse(vetPeca2[0]);

int nPeca2 = int.Parse(vetPeca2[1]);

double valorPecaUnitaria2 = double.Parse(vetPeca2[2]);

double calc = (nPeca1 * valorPecaUnitaria1) + (nPeca2 * valorPecaUnitaria2);

Console.WriteLine("VALOR A PAGAR: R$ " + calc.ToString("F2"));
