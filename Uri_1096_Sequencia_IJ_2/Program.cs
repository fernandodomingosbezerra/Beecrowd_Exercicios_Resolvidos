﻿// See https://aka.ms/new-console-template for more information
Console.Clear();

for (int i = 1; i <= 9; i += 2)
{
    for (int j = 7; j >= 5; j--)
    {
        Console.Write("I=" + i + "J=" + j + "\n");
    }
}