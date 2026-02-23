using System;

class Program
{
    static void Main()
    {
        int number;
        bool Chislo = false;
        while (!Chislo)
        {
            Console.Write("Пожалуйста, введите число: ");
            string userInput = Console.ReadLine();
            Chislo = IsNumber(userInput);
            if (!Chislo)
            {
                Console.WriteLine("Ошибка! Пожалуйста, введите число.");
            }
            else
            {
                number = Convert.ToInt32(userInput);
                Console.WriteLine(number);
            }
        }
    }
    static bool IsNumber(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        foreach (char c in input)
        {
            if (!char.IsDigit(c)) return false;
        }
        return true;
    }
}