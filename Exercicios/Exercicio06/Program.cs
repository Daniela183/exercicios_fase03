Console.WriteLine("6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:");

Console.WriteLine("\nForma 01");
for (int i = 10; i <= 20; i += 2)
{
    if (i == 16)
        continue;
    Console.Write($"i = {i} ");
}

Console.WriteLine("\n\nForma 02");
for (int i = 10; i <= 20; i++)
{
    if (i % 2 == 1)
        continue;
    if (i == 16)
        continue;
    Console.Write($"i = {i} ");
}
Console.WriteLine("\n\nForma 03");
for (int i = 10; ; i += 2)
{
    if (i == 16)
        continue;
    if (i > 20)
        break;
    Console.Write($"i = {i} ");
}


Console.ReadKey();