using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Базовый класс Бытовая техника
    public class HomeAppliance
    {
        protected string model;
        protected string manufacturer;
        protected double price;
        protected int year;

    public HomeAppliance(string m = "Unknown", string manu = "Unknown", double p = 0.0, int y = 2000)
    {
        model = m;
        manufacturer = manu;
        price = p;
        year = y;
    }

    public override string ToString()
    {
        return $"Model: {model}, Manufacturer: {manufacturer}, Price: {price} RUB, Year: {year}";
    }

    public interface ICloneable
    {
        object Clone();
    }

    public object Clone()
    {
        return new HomeAppliance(model,manufacturer,price,year);
    }

    public virtual void Print()
    {
        Console.WriteLine($"Model: {model}, Manufacturer: {manufacturer}, Price: {price} RUB, Year: {year}");
    }

    // Геттеры
    public string GetModel { get { return model; } }
    public string GetManufacturer { get { return manufacturer; } }
    public double GetPrice { get { return price; } }
    public int GetYear { get { return year; } }

    // Сеттеры
    public double SetPrice
    {
        set
        {
            if (value < 0)
                throw new ArgumentException("Price cannot be negative.");
            else
                price = value;
        }
    }
    public int SetYear
    {
        set
        {
            int currentYear = 2024;
            if (value < 1980 || value > currentYear)
                throw new ArgumentException($"Year must be between 1980 and {currentYear}.");
            else
                year = value;
        }
    }
}
public class ApplianceComparer : IComparer<HomeAppliance>
{
    public int Compare(HomeAppliance x, HomeAppliance y)
    {
        if (x.GetYear != y.GetYear)
            return 0;

        else if (x.GetPrice != y.GetPrice)
            return 0;

        else if (x.GetModel != y.GetModel)
            return 0;

        else return 1;

    }
}


/*public static IComparer SortYearAscending()
{
    return (IComparer)new SortYearAscendingHelper();
}*/
/*////



using System;
using System.Collections.Generic;

public class ApplianceComparer : IComparer<HomeAppliance>
{
    public int Compare(HomeAppliance x, HomeAppliance y)
    {
        if (x == null && y != null)
            return -1;
        if (y == null && x != null)
            return 1;
        if (x == null && y == null)
            return 0;

        if (x.GetYear != y.GetYear)
            return x.GetYear.CompareTo(y.GetYear);

        if (x.GetPrice != y.GetPrice)
            return x.GetPrice.CompareTo(y.GetPrice);

        if (x.GetModel != y.GetModel)
            return String.Compare(x.GetModel, y.GetModel);

        return String.Compare(x.GetManufacturer, y.GetManufacturer);
    }
}

class Program
{
    static void Main()
    {
        List<HomeAppliance> appliances = new List<HomeAppliance>()
        {
            new HomeAppliance("Washing Machine", "Samsung", 20000, 2021),
            new HomeAppliance("Refrigerator", "LG", 60000, 2020),
            new HomeAppliance("Air Conditioner", "Panasonic", 70000, 2022),
            new HomeAppliance("Vacuum", "Xiaomi", 10000, 2023),
            new HomeAppliance("Microwave Oven", "Whirlpool", 30000, 2020)
        };

        ApplianceComparer comparer = new ApplianceComparer();
        appliances.Sort(comparer);

        Console.WriteLine("Sorted by year descending:");
        foreach (var appliance in appliances)
        {
            appliance.Print();
        }

        Console.WriteLine("\nSorted by price ascending:");
        appliances.Sort((x, y) => Comparer<double>.Default.Compare(x.GetPrice, y.GetPrice));
        foreach (var appliance in appliances)
        {
            appliance.Print();
        }

        Console.ReadKey();
    }
}*/
