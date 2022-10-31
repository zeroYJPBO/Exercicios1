/* Estudo de caso resolvido por João Paulo Bezerra Oliveira
 * Estudante do curso de Desenvolvimento de Sistemas 4.0 no SENAI Dr. Celso Charuri (Curitiba)
 * Curitiba, 30 de outubro de 2022
*/

/* Leia um valor inteiro, que é o tempo de duração em segundos de um determinado
 * evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos. */

int N, horas, resto, minutos, segundos;

N = int.Parse(Console.ReadLine());

horas = N / 3600;

resto = N % 3600;

minutos = resto / 60;

segundos = resto % 60;

Console.WriteLine(horas + ":" + minutos + ":" + segundos);