using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте! Как Вас зовут?");
        string name = Console.ReadLine();
        Console.WriteLine("Приветствуем Вас, " + name + "!");
        Console.ReadLine();
    }
}