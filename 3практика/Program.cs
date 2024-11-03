using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//Задание 4
class Program
{
    static void Main(string[] args)
    {
        // Создаем коллекцию и регистрируем обработчик события
        ObservableCollection<HomeAppliance> appliances = new ObservableCollection<HomeAppliance>();
        appliances.CollectionChanged += Appliances_CollectionChanged;

        // Добавляем элементы в коллекцию
        appliances.Add(new HomeAppliance("Model A", "Manufacturer X", 1000.0, 2020));
        appliances.Add(new HomeAppliance("Model B", "Manufacturer Y", 2000.0, 2020));
        appliances.Add(new HomeAppliance("Model C", "Manufacturer Z", 3000.0, 2018));
        appliances.Add(new HomeAppliance("Model D", "Manufacturer W", 4000.0, 2019));

        // Удаляем элемент из коллекции
        Console.WriteLine("Удаление из колекции первого элемента");
        appliances.RemoveAt(0);  // Удаляем первый элемент

        // Выводим оставшиеся элементы
        Console.WriteLine("Оставшиеся элементы");
        foreach (var appliance in appliances)
        {
            appliance.Print();
        }
    }
    private static void Appliances_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            foreach (HomeAppliance newAppliance in e.NewItems)
            {
                Console.WriteLine($"Added: {newAppliance}");
            }
        }
        else if (e.Action == NotifyCollectionChangedAction.Remove)
        {
            foreach (HomeAppliance oldAppliance in e.OldItems)
            {
                Console.WriteLine($"Removed: {oldAppliance}");
            }
        }
    }
}

//Задание 3
/*class Program
{
    static void Main()
    {
        var appliances = new List<HomeAppliance>();
        appliances.Add(new HomeAppliance("Model A", "Manufacturer X", 1000.0, 2020));
        appliances.Add(new HomeAppliance("Model B", "Manufacturer Y", 2000.0, 2020));
        appliances.Add(new HomeAppliance("Model C", "Manufacturer Z", 3000.0, 2018));
        appliances.Add(new HomeAppliance("Model D", "Manufacturer W", 4000.0, 2019));

        List<HomeAppliance> appliancess = new List<HomeAppliance>()
        {
            new HomeAppliance("Washing Machine", "Samsung", 20000, 2020),
            new HomeAppliance("Refrigerator", "LG", 60000, 2020),
            new HomeAppliance("Air Conditioner", "Panasonic", 70000, 2022),
            new HomeAppliance("Vacuum", "Xiaomi", 10000, 2023),
            new HomeAppliance("Microwave Oven", "Whirlpool", 30000, 2020)
        };

        ApplianceComparer comparer = new ApplianceComparer();
        appliances.Sort(comparer);

        // Сравнение двух объектов
        var appA = appliancess[0];
        var appB = appliancess[1];
        //int comparisonResult = appA.CompareTo(appB);
        //Console.WriteLine("Результат сравнения объектов: " + comparisonResult);

        //int comparisonResult = ApplianceComparer.Compare(appliances[0], appliances[1]);
        int comparisonResult = comparer.Compare(appA, appB);
        Console.WriteLine("Результат сравнения объектов: " + comparisonResult);

        // Глубокое копирование объекта
        var clonedAppliance = (HomeAppliance)appliances[0].Clone();
        Console.WriteLine("Результат копирования объектов: ");
        Console.WriteLine("Объект исходный: ");
        appliances[0].Print();
        Console.WriteLine("Объект скопированный: ");
        clonedAppliance.Print();

        // Вывод коллекции
        Console.WriteLine("Исходная коллекция:");
        foreach (var appliance in appliances)
        {
            appliance.Print();
        }

        Console.ReadKey();
    }
}*/

//Задание 2
/*class Program
{
    static void Main()
    {
        int n = 1;
        int searchValue = 4;

        // a) Первая коллекция
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // b) Вывод первой коллекции на консоль
        Console.WriteLine("Первая коллекция:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }



        // c) Удалить n элементов
        while (n > 0)
        {
            queue.Dequeue();
            n--;
        }

        // d) Добавить другие элементы
        queue.Enqueue(4);
        queue.Enqueue(5);

        // e) Создание второй коллекции
        List<int> list = new List<int>(queue);

        // f) Вывести вторую коллекцию на консоль
        Console.WriteLine("\nВторая коллекция:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // g) Найти заданное значение
        bool isFound = list.Exists(x => x == searchValue);
        Console.WriteLine($"\nЗначение {searchValue} найдено: {isFound}");

        Console.ReadKey();
    }
}
*/

//Задание 1
/*namespace otter
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchValue = "Лука";
            int indexToRemove = 4;
            // a) Создаем пустую коллекцию ArrayList
            ArrayList list = new ArrayList();

            // b) Заполняем список 5-ю случайными целыми числами
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                list.Add(rnd.Next(100));

            // c) Добавляем строку
            list.Add("Лука");

            // d) Удаляем заданный элемент
            list.RemoveAt(indexToRemove);

            // e) Выводим количество элементов и коллекцию на консоль
            Console.WriteLine($"Количество элементов: {list.Count}");
            foreach (var item in list)
                Console.Write($"{item}, ");

            // f) Выполняем поиск в коллекции заданного значения
            if (list.Contains(searchValue))
                Console.WriteLine($"Элемент '{searchValue}' найден.");
            else
                Console.WriteLine($"Элемент '{searchValue}' не найден.");

            Console.ReadKey();
        }
    }
}*/
