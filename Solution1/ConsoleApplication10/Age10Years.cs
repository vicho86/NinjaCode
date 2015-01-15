// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeIn10Years

{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine( "Your age will be " + (age + 10) + " in 10 years!");
    }
        
}
