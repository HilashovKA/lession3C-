void FindRange (int number)
{
    if (number == 1)
        Console.WriteLine("X > 0, Y > 0");
    else if (number == 2)
        Console.WriteLine("X < 0, Y > 0");
    else if (number == 3)
        Console.WriteLine("X < 0, Y < 0");
    else if (number == 4)
        Console.WriteLine("X > 0, Y < 0");
    else 
        Console.WriteLine("Введите корректный номер ");

}

FindRange(1);
FindRange(3);
FindRange(-2);
FindRange(4);

