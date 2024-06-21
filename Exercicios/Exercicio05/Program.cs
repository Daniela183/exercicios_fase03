Console.WriteLine("5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de resposta de uma pergunta. O usuário " +
    "pode optar por continuar respondendo a pergunta ou parar de responder.Não utilize a instrução break.");

string resposta;
bool condicao = true;
Console.WriteLine("\nQual a instrução para sair de um loop ?");
Console.WriteLine("a. quit");
Console.WriteLine("b. continue");
Console.WriteLine("c. break");
Console.WriteLine("d. exit");
while (condicao)
{
    Console.WriteLine("\nQual a opção correta ? (Tecle x para sair)");
    resposta = Console.ReadLine().ToLower();
    if (resposta == "c")
    {
        Console.WriteLine("Resposta Correta !");
        condicao = false;
    }
    else if (resposta == "x")
    {
        Console.WriteLine("Programa encerrado");
        condicao = false;
    }
    else
    {
        Console.WriteLine("Resposta Incorreta !!!");
    }
}

Console.ReadKey();