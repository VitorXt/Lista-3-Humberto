int[,] jureg = new int[3, 3];
int maior = jureg[0, 0];
int soma = 0;
int quantidadePrimos = 0;

static bool EhPrimo(int num)
{
    if (num < 2)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Insira um valor para a posição [" + i + "," + j + "]: ");
        jureg[i, j] = Convert.ToInt32(Console.ReadLine());

        soma += jureg[i, j];

        if (jureg[i, j] > maior)
        {
            maior = jureg[i, j];
        }

        if (EhPrimo(jureg[i, j]))
        {
            quantidadePrimos++;
        }
    }
}

Console.WriteLine("\nMatriz preenchida pelo usuário: ");
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(jureg[i, j] + " ");
    }

    Console.WriteLine();
}

Console.WriteLine("\nO maior elemento da matriz é: " + maior);
Console.WriteLine("\nA soma dos elementos da matriz é: " + soma);
Console.WriteLine("\nA quantidade de números primos na matriz é: " + quantidadePrimos);
