Console.WriteLine("1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior");

int num1, num2, num3;
Console.Write("\nEncontre o maior dentre 3 números:\n");

Console.Write("Primeiro Número: \t");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Segundo Número: \t");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Terceiro Número: \t");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
        Console.Write($"O primeiro número é o maior ({num1}).\n");
    else
        Console.Write($"O terceiro número é o maior ({num3}).\n");
}
else if (num2 > num3)
    Console.Write($"O segundo número é o maior ({num2}).\n");
else
    Console.Write($"O terceiro número é o maior ({num3}).\n");

Console.ReadKey();