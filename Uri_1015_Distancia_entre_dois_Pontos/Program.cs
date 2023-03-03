﻿using System;
using System.Globalization;

namespace Uri_1015_Rqrt_Pow{
    class Program{
        static void Main(string[]agrs){
          Console.Clear();

          string[] valores = Console.ReadLine().Split(' ');
          double x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
          double y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

          valores = Console.ReadLine().Split(' ');
          double x2 = double.Parse(valores[0], CultureInfo.InvariantCulture);
          double y2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

          double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

          Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}