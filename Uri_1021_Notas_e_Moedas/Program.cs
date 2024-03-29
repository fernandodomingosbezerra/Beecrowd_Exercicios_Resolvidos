﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Clear();

int  quociente, resto, nota, moeda;
double N;

N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Vamos multiplicar N por 100 e forçar a conversão para int.
// Desse modo, por exemplo, 576.73 vai se tornar 57673

// Vamos tambem somar 0.5 antes de converter, para assegurar 
// que o numero seja devidamente arredondado, pois o tipo double
// as vezes da problema de arredondamento (por exemplo: se digitarmos
// 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
// dai o casting resultaria em 57680 e nao 57681 como desejado

resto = (int) (N * 100.0 + 0.5);
Console.WriteLine("NOTAS: ");

// como multiplicamos o valor por 100 acima, o valor de cada nota
// também deverá ser multiplicado por 100 a seguir
nota = 100;
quociente = resto / (nota * 100);
Console.WriteLine(quociente + " notas(s) de R$ " + nota + ".00");
resto = resto % (nota * 100);

nota = 50;
quociente = resto / (nota * 100);
Console.WriteLine(quociente + " notas(s) de R$ " + nota + ".00");
resto = resto % (nota * 100);

nota = 20;
quociente = resto / (nota * 100);
Console.WriteLine(quociente + " notas(s) de R$ " + nota + ".00");
resto = resto % (nota * 100);

nota = 10;
quociente = resto / (nota * 100);
Console.WriteLine(quociente + " notas(s) de R$ " + nota + ".00");
resto = resto % (nota * 100);

nota = 5;
quociente = resto / (nota * 100);
Console.WriteLine(quociente + " notas(s) de R$ " + nota + ".00");
resto = resto % (nota * 100);

nota = 2;
quociente = resto / (nota * 100);
Console.WriteLine(quociente + " notas(s) de R$ " + nota + ".00");
resto = resto % (nota * 100);

Console.WriteLine("MOEDAS: ");

moeda = 100;
quociente = resto / moeda;
Console.WriteLine(quociente + " moeda(s) de R$ 1.00");

moeda = 50;
quociente = resto / moeda;
Console.WriteLine(quociente + " moeda(s) de R$ 0.50");

moeda = 20;
quociente = resto / moeda;
Console.WriteLine(quociente + " moeda(s) de R$ 0.20");

moeda = 10;
quociente = resto / moeda;
Console.WriteLine(quociente + " moeda(s) de R$ 0.10");

moeda = 5;
quociente = resto / moeda;
Console.WriteLine(quociente + " moeda(s) de R$ 0.05");

Console.WriteLine(resto + " moeda(s) de R$ 0.01");





