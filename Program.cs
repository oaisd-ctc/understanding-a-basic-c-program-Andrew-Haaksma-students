// See https://aka.m/snew-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("My name is Andrew Haaksma.");

        //using Variables
        int age = 17;
        string greeting = "Hello World";
        string firstname = "Andrew";
        string lastname = "Haaksma";
        double money = 2.79;

        Console.WriteLine(greeting + "!" + "My name is" + firstname + "" + lastname + ". I am " + age + " years old. I just spent $" + money + " on an Energy Drink");
    }
}