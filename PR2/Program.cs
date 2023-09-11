using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string inputString = Console.ReadLine();

        char charResult;
        bool charSuccess = Char.TryParse(inputString, out charResult);

        int intResult;
        bool intSuccess = Int32.TryParse(inputString, out intResult);

        double doubleResult;
        bool doubleSuccess = Double.TryParse(inputString, out doubleResult);

        bool boolResult;
        bool boolSuccess = Boolean.TryParse(inputString, out boolResult);

        if (intSuccess)
        {
            Console.WriteLine("Строка является целым числом: " + intResult);
        }
        else if (charSuccess)
        {
            Console.WriteLine("Строка является символом: " + charResult);
        }
        else if (doubleSuccess)
        {
            Console.WriteLine("Строка является дробным числом: " + doubleResult);
        }
        else if (boolSuccess)
        {
            Console.WriteLine("Строка является логическим выражением: " + boolResult);
        }
        else
        {
            Console.WriteLine("Строка не соответствует ни одному из этих типов данных.");
        }
    }
}
