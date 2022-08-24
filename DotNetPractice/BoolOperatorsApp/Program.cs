using System.Globalization;
using System.Text;
using System.Text.Json;

bool myVar1 = false;

bool myVar2 = true;

/* конъюнкция - "и"
a && b 

0 && 0 = 0
0 && 1 = 0
1 && 0 = 0
1 && 1 = 1

a && 1 = a
a && 0 = 0

Sample:
a && b && c || 1 && a = a && b && c || a = a && b && c
 */
if (myVar1 && myVar2)
{
    Console.WriteLine("myVar is true");
}
else
{
    Console.WriteLine("myVar is false");
}

/* дизъюнкция "или"
a || b 

0 || 0 = 0
0 || 1 = 1
1 || 0 = 1
1 || 1 = 1

a || 1 = 1
a || 0 = a
 */

if (myVar1 || myVar2)
{
    Console.WriteLine("myVar is true");
}
else
{
    Console.WriteLine("myVar is false");
}

/*
 отрицание

 !(a && b) = !a || !b
 !(a || b) = !a && !b
 */

if (!myVar1)
{
    Console.WriteLine("myVar is false");
}
else
{
    Console.WriteLine("myVar is true");
}

/*
 XOR - исключающее или

a ^ b 
0 ^ 0 = 0
0 ^ 1 = 1
1 ^ 0 = 1
1 ^ 1 = 0
 */
if (myVar1 ^ myVar2)
{
    Console.WriteLine("We are here!");
}
else
{
    Console.WriteLine("We are here!");
}

// -------------------
if (!myVar2)
{
    Console.WriteLine("myVar2 is true");
}

/*

Десятиричная     Бинарная     Шестнадцатиричная
0                0            0
1                1            1
2                10           2
3                11           3
4                100          4
5                101          5
6                110          ...
7                111
8                1000
9                1001         9
10               1010         A
11               1011         B
12               1100         C
13               1101         D
14               1110         E
15               1111         F
16               10000        10

 */

Console.WriteLine("Hello, Man!");

Console.ReadKey(true);