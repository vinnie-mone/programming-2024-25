using System;
using System.Collections.Generic;
using System.Linq;

/*class Program
{
    static void Main()
    {
        string[] months = { "June", "July", "May", "December", "January", "February", "March", "April", "August", "September", "October", "November" };

        // Запрос для выбора месяцев с длиной строки равной n
        int length = 4;
        var result1 = from month in months
                      where month.Length == length
                      select month;
        Console.WriteLine("Месяцы с длиной строки равной {0}:", length);
        foreach (var item in result1)
            Console.WriteLine(item);

        // Запрос для выбора летних и зимних месяцев
        var result2 = from month in months
                      where (month == "June" || month == "July" || month == "August") ||
                            (month == "December" || month == "January" || month == "February")
                      select month;
        Console.WriteLine("\nЛетние и зимние месяцы:");
        foreach (var item in result2)
            Console.WriteLine(item);

        // Запрос для сортировки месяцев в алфавитном порядке
        var result3 = from month in months
                      orderby month
                      select month;
        Console.WriteLine("\nМесяцы в алфавитном порядке:");
        foreach (var item in result3)
            Console.WriteLine(item);

        // Запрос для подсчета месяцев, содержащих букву 'u' и длиной не менее 4 символов
        var result4 = from month in months
                      where month.Contains('u') && month.Length >= 4
                      select month;
        Console.WriteLine("\nМесяцы, содержащие букву 'u' и длиной не менее 4 символов:");
        foreach (var item in result4)
            Console.WriteLine(item);

        Console.ReadKey();
    }
}*/
