using System;

bool perfSquare(int n)
{
    int s = (int)Math.Sqrt(n);
    return (s * s == n);
}

bool fib(int n)
{
    return perfSquare(5 * n * n + 4) || perfSquare(5 * n * n - 4);
}

int myNumber = 55;
if (fib(myNumber))
{
    Console.WriteLine($"{myNumber} is a Fibonacci number");
}
else
{
    Console.WriteLine($"{myNumber} is not a Fibonacci number");
}
