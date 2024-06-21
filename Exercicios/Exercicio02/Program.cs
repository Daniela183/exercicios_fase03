Console.WriteLine("2- Escreva um programa para calcular a raiz da equação quadrática: ax^2 +bx + x = 0  (1 -1 -12)");

int a, b, c;
double d, x1, x2;

Console.Write("\nCálculo da equação do segundo grau:\n");

Console.Write("Informe o valor de a:\t");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de b:\t");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de c:\t");
c = Convert.ToInt32(Console.ReadLine());
d = b * b - 4 * a * c;

if (d == 0)
{
    Console.Write("As duas raízes são iguais.\n");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.Write($"Primeira raiz x1= {x1}\n");
    Console.Write($"Segunda raiz x2= {x2}\n");
}
else if (d > 0)
{
    Console.Write("\nAmbas as raízes são reais e diferentes\n");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.Write($"\nPrimeira raiz x1= {x1}\n");
    Console.Write($"Segunda raiz x2= {x2}\n");
}
else
    Console.Write("As raízes são imaginárias;\nSem solução para os números reais.\n");

Console.ReadKey();