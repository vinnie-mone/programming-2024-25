using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Book
{
    private string _title;
    private string _author;
    private int _yearOfPublication;
    private int _numberOfPages;
    private decimal _price;

    public string Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Название книги не может быть пустым.");
            _title = value;
        }
    }

    public string Author
    {
        get => _author;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Имя автора не может быть пустым.");
            _author = value;
        }
    }

    public int YearOfPublication
    {
        get => _yearOfPublication;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Год издания должен быть положительным числом.");
            _yearOfPublication = value;
        }
    }

    public int NumberOfPages
    {
        get => _numberOfPages;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Количество страниц должно быть больше нуля.");
            _numberOfPages = value;
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Цена должна быть неотрицательной.");
            _price = value;
        }
    }

    // Конструктор без параметров
    public Book() {}

    // Конструктор с параметрами
    public Book(string title, string author, int yearOfPublication, int numberOfPages, decimal price)
    {
        Title = title;
        Author = author;
        YearOfPublication = yearOfPublication;
        NumberOfPages = numberOfPages;
        Price = price;
    }

    // Индексатор для доступа к страницам книги
    public string this[int pageNumber]
    {
        get
        {
            if (pageNumber < 1 || pageNumber > NumberOfPages)
                throw new IndexOutOfRangeException($"Страница {pageNumber} выходит за пределы книги.");
            return $"Вы просматриваете страницу {pageNumber}.";
        }
    }

    // Метод для получения информации о книге
    public override string ToString()
    {
        return $"Название: {_title}, Автор: {_author}, Год издания: {_yearOfPublication}, Страниц: {_numberOfPages}, Цена: {_price} р";
    }
}

/*class Program
{
    static void Main()
    {
        // Создаем список книг
        List<Book> books = new List<Book>
        {
            new Book("Великий Гэтсби", "Ф. Скотт Фицджеральд", 1925, 180, 300),
            new Book("1984", "Джордж Оруэлл", 1949, 328, 200),
            new Book("Преступление и наказание", "Ф.М. Достоевский", 1866, 485, 450)
        };

        // Выводим информацию о каждой книге
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}*/


class Program
{
    static void Main()
    {
        // Список книг
        List<Book> books = new List<Book>
        {
            new Book("Великий Гэтсби", "Ф. Скотт Фицджеральд", 1925, 180, 300),
            new Book("1984", "Джордж Оруэлл", 1949, 328, 200),
            new Book("Преступление и наказание", "Ф.М. Достоевский", 1866, 485, 450),
            new Book("Война и мир", "Лев Толстой", 1869, 1225, 440),
            new Book("Гарри Поттер и филосовский камень", "Д.К. Роулинг", 1997, 223, 895),
            new Book("Над пропастью во ржи", "Дж.Д. Селинджер", 1951, 277, 450),
            new Book("Скотный двор", "Джордж Оруэлл", 1945, 112, 250),
            new Book("Хоббит", "Дж.Р.Р. Толкин", 1937, 310, 500),
            new Book("Убить пересмешника", "Харпер Ли", 1960, 281, 430),
            new Book("Властелин колец", "Дж.Р.Р. Толкин", 1954, 1216, 950)
        };

        // Список книг заданного автора
        string author = "Джордж Оруэлл";
        var booksByAuthor = books.Where(b => b.Author == author);
        DisplayBooks("Книги автора " + author, booksByAuthor);

        // Список книг, выпущенных после заданного года
        int year = 1950;
        var booksAfterYear = books.Where(b => b.YearOfPublication > year);
        DisplayBooks("Книги, выпущенные после " + year, booksAfterYear);

        // Самая тонкая книга
        var thinnestBook = books.OrderBy(b => b.NumberOfPages).First();
        Console.WriteLine("Самая тонкая книга: " + thinnestBook.Title);

        // 5 первых самых толстых книг
        var fiveThickestBooks = books.OrderByDescending(b => b.NumberOfPages).Take(5);
        DisplayBooks("5 первых самых толстых книг", fiveThickestBooks);

        // Список книг, отсортированных по цене
        var sortedByPrice = books.OrderBy(b => b.Price);
        DisplayBooks("Список книг, отсортированных по цене", sortedByPrice);
    }

    static void DisplayBooks(string message, IEnumerable<Book> books)
    {
        Console.WriteLine(message);
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine();
    }
}

