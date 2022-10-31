/* Estudo de caso resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

/* Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas,
com uma casa decimal, conforme exemplo. */

string[] vet1 = Console.ReadLine().Split(' ');
string[] vet2 = Console.ReadLine().Split(' ');

string nome1 = vet1[0];
double idade1 = double.Parse(vet1[1]);
string nome2 = vet2[0];
double idade2 = double.Parse(vet2[1]);

double calc1 = (idade1 + idade2) / 2.0;

Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + calc1.ToString("F1") + " anos"); ;