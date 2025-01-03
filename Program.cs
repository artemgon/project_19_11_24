using project_19_11_24.Classes;
using System;

int a = 5, b = 10;
double Product(int x, int y)
{
    double product = 1;
    int i = (x < y) ? x : y;
    int i1 = (x < y) ? y : x;
    for (; i <= i1; i++)
    {
        product *= i;
    }
    return product;
}

Console.WriteLine($"Product of range {a} to {b} is {Product(a, b)}");
