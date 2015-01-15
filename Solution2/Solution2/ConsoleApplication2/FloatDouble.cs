// Problem 2. Float or Double?
// 
//     Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//     34.567839023, 12.345, 8923.1234857, 3456.091?
//     Write a program to assign the numbers in variables and print them to ensure no precision is lost.


using System;

class Program
{
    static void Main()
    {
        float f1 = 12.345f;
        float f2 = 3456.091f;
        double d1 = 34.567839023;
        double d2 = 8923.1234857;

        Console.WriteLine(f1);
        Console.WriteLine(f2);
        Console.WriteLine(d1);
        Console.WriteLine(d2);
    }
}
