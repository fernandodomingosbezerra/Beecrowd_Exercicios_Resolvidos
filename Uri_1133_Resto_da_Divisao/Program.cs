﻿// See https://aka.ms/new-console-template for more information
Console.Clear();

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if(x > y){
    int aux = x;
    x = y;
    y = aux;

}
for(int i = x + 1; i <y; i++){
    if (i % 5 == 2 || i % 5 == 3){
        Console.WriteLine(i);
    }
}