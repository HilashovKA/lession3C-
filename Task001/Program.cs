int findQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    
    return 0;
}

Console.WriteLine (findQuarter(0,5));
Console.WriteLine (findQuarter(-19,7));
Console.WriteLine (findQuarter(-1,-3));
Console.WriteLine (findQuarter(4,-8));
Console.WriteLine (findQuarter(10,6));
