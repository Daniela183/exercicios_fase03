Console.WriteLine("8- Escreva um programa para calcular o fatorial de um número inteiro. \r\nO fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 " +
    "\r\nExemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1\r\n");

int i, f = 1, num;

Console.Write("Cálculo do fatorial de um número\n");
Console.Write("\nInforme o número inteiro maior que zero: \t");
num = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= num; i++)
    f = f * i;
Console.Write($"\nO fatorial de {num} é: {f}\n");


Console.ReadKey();