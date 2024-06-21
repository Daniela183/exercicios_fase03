Console.WriteLine("11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros. (considere que na divisão podemos " +
    "ter números fracionários e que não existe divisão por zero e quando isso ocorrer exibir uma mensagem de alerta)");

int num1;
int num2;

string operando;
float resposta;

Console.Write("\nInforme o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o operando (+, -, /, *): ");
operando = Console.ReadLine();

Console.Write("Informe o segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

switch (operando)
{
    case "-":
        resposta = num1 - num2;
        break;
    case "+":
        resposta = num1 + num2;
        break;
    case "/":
        resposta = (float)num1 / num2;
        break;
    case "*":
        resposta = num1 * num2;
        break;
    default:
        resposta = 0;
        break;
}
Console.WriteLine($"\nResultado: {num1} {operando} {num2} = {resposta} \n\nPrograma encerrado");

Console.ReadKey();