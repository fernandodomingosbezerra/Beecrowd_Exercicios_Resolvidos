﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.Clear();

double a, b, c, perimetro, area;

string[] valores = Console.ReadLine().Split(' ');

a = double.Parse(valores[0], CultureInfo.InvariantCulture);
b = double.Parse(valores[1], CultureInfo.InvariantCulture);
c = double.Parse(valores[2], CultureInfo.InvariantCulture);

if(a < b + c && b < a + c && c < a + b){
    perimetro = a + b + c;
    Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
}
else{
    area = ((a + b) * c)/ 2;
    Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
}