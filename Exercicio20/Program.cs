/* Exercício do URI Online Judge/beecrowd resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

uint valor = uint.Parse(Console.ReadLine());

uint anos, meses, dias, resto;

anos = valor / 365;

meses = (valor % 365) / 30;

dias = (valor % 365) % 30;

Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses + " mes(es)");
Console.WriteLine(dias + " dia(s)");