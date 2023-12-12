Console.WriteLine("Введите размернорсть 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность 2");
int b = Convert.ToInt32(Console.ReadLine());
int[,] ints = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        ints[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int min = ints[0, 0];
int max = ints[0, 0];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        if (ints[i, j] < min)
        {
            min = ints[i, j];

        }
        if (ints[i, j] > max)
        {
            max = ints[i, j];
        }
    }
}
Console.WriteLine($"Минимальный элемент:{min} максимальный элемент:{ max}");