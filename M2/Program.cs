int[,] jureg = new int[3, 3];
float[] medias = new float[3];

for (int i = 0; i < 3; i++)
{
    float media = 0;


    for (int j = 0; j < 3; j++)
    {
        media += jureg[j, i];

        Console.Write("Insira um valor para a posição [" + i + "," + j + "]: ");
        jureg[i, j] = Convert.ToInt32(Console.ReadLine());
    }

    
}

for (int i = 0; i < 3; i++)
{
    medias[i] = (jureg[0, i] + jureg[1, i] + jureg[2, i]) / 3;
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

Console.WriteLine("\nMédias das colunas:");
Console.WriteLine();
for (int i = 0; i < 3; i++)
{

    Console.WriteLine("Coluna {0}: {1}", i + 1, medias[i]);
}