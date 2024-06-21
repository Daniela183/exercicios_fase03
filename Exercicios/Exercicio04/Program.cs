Console.WriteLine("4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero \r\nrecebido via teclado" +
    "- Considere a tabela de multiplicação de 1 até 10\r\n- Após exibir a tabela torne a solicitar outro número \r\n- Para sair defina uma condição de saída " +
    "\r\n- Verifique se o número é maior que zero e emita uma mensagem\r\n- Dica: Use os loop while e for e para sair a instrução break");

while (true)
{
    int numero;
    int contador = 1;

    Console.Write("\nDigite um número maior que zero ('00' sai): ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 00)
    {
        Console.WriteLine("\nPrograma encerrado ");
        break;
    }

    if (numero > 0)
    {
        Console.WriteLine($"\nTabuado do {numero}\n");
        while (contador < 11)
        {
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            contador++;
        }
    }
    else
    {
        Console.WriteLine("\nO número deve ser maior que zero");
    }
}

Console.ReadKey();