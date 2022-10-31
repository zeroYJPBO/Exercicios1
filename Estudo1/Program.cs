/* Estudo de caso resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

/* Fazer um programa para ler as medidas da base e altura de um retângulo. Em
seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
casas decimais, conforme exemplo. */

double baseR = double.Parse(Console.ReadLine());

double alturaR = double.Parse(Console.ReadLine());

double area = baseR * alturaR;

double perimetro = 2 * (baseR + alturaR);

double diagonal = Math.Sqrt(Math.Pow(baseR, 2.0) + Math.Pow(alturaR, 2.0));

Console.WriteLine("AREA = " + area.ToString("F4"));
Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));