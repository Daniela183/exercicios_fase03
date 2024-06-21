Console.WriteLine("10- Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de um aluno. Com base na tabela a seguir " +
    "imprima no console qual o resultado da avaliação do aluno. (Use a instrução switch, break e default em um loop infinito e defina uma condição de saida.)");

while (true)
{
    Console.Write("\nInforme a nota do aluno (99 sai): ");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 99)
    {
        Console.WriteLine("\nPrograma encerrado ");
        break;
    }
    Console.Write("\nResultado da avaliação: \t");
    switch (x)
    {
        case 10:
            Console.WriteLine("A+");
            break;
        case 9:
            Console.WriteLine("A+");
            break;
        case 8:
        case 7:
            Console.WriteLine("B");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        default:
            Console.WriteLine("F");
            break;
    }
}


Console.ReadKey();