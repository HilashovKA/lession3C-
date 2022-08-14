void N (int number)
{
    int index = 1;
    while (index < number)
    {
        Console.Write($"{index*index*index}, ");
        index++;
    }
    Console.Write($"{index*index*index} " );
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
N(num);