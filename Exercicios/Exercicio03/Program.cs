Console.WriteLine("3- Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.");

Console.WriteLine("\nLoop While");
int i = 1, soma = 0;

Console.Write("Os 10 primeiros números naturais são: ");

while (i <= 10)
{
    soma = soma + i;
    Console.Write($"{i} ");
    i++;
}
Console.Write($"\nA soma dos números é: {soma}\n");

Console.WriteLine("\nLoop do-While");
int j = 1, som = 0;

Console.Write("Os 10 primeiros números naturais são: ");
do
{
    som = som + j;
    Console.Write($"{j} ");
    j++;
}
while (j <= 10);
Console.Write($"\nA soma dos números é: {som}\n");

Console.WriteLine("\nLoop For");
int l, sm = 0;

Console.Write("Os 10 primeiros números naturais são: ");
for (l = 1; l <= 10; l++)
{
    sm = sm + l;
    Console.Write($"{l} ");
}
Console.Write($"\nA soma dos números é: {sm}\n");

Console.ReadKey();