Console.WriteLine("7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*).\r\nEx:\r\n*\r\n**\r\n***\r\n**** \n(dica:loop aninhado)\r\n");

int i, j, linhas;

Console.Write("Informe o número de linhas: ");
linhas = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= linhas; i++)
{
    for (j = 1; j <= i; j++)
        Console.Write("*");
    Console.Write("\n");
}

Console.ReadKey();