using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Task1
        //Car car1 = new Car(1, "Ford Mustang", 180, 1);
        //Car car2 = new Car(2, "Chevrolet Camaro", 200, 2);
        //Car car3 = new Car(3, "Porsche 911", 220, 3);

        //Gallery gallery = new Gallery(1, "Cars Gallery");

        //gallery.AddCar(car1);
        //gallery.AddCar(car2);
        //gallery.AddCar(car3);

        //Console.WriteLine("All Cars in Gallery:");
        //gallery.ShowAllCars();

        //Console.WriteLine("\nFind Car by Id (Id = 2):");
        //var foundCarById = gallery.FindCarById(2);
        //if (foundCarById != null)
        //    Console.WriteLine($"Id: {foundCarById.Id}, Name: {foundCarById.Name}, Speed: {foundCarById.Speed}, CarCode: {foundCarById.CarCode}");

        //Console.WriteLine("\nFind Car by CarCode (CarCode = FO1001):");
        //var foundCarByCarCode = gallery.FindCarByCarCode("FO1001");
        //if (foundCarByCarCode != null)
        //    Console.WriteLine($"Id: {foundCarByCarCode.Id}, Name: {foundCarByCarCode.Name}, Speed: {foundCarByCarCode.Speed}, CarCode: {foundCarByCarCode.CarCode}");

        //Console.WriteLine("\nFind Cars with Speed between 130 and 160:");
        //var carsBySpeed = gallery.FindCarsBySpeedInterval(130, 160);
        //if (carsBySpeed != null)
        //{
        //    foreach (var car in carsBySpeed)
        //        Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");           
        //}
        //else
        //    Console.WriteLine("No cars found in the specified speed range.");
        #endregion

        Book book1 = new Book(1, "The Silent Forest", 14.90, 50, "Nature");
        Book book2 = new Book(2, "Journey to the Unknown", 19.90, 30, "Adventure");
        Book book3 = new Book(3, "Mysteries of the Past", 8, 10, "History");

        Library library = new Library(4);
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("Find book by Id (Id = 2):");
        var foundBookById = library.GetBookById(2);
        if (foundBookById != null)
            Console.WriteLine($"Id: {foundBookById.Id}, Name: {foundBookById.Name}, Genre: {foundBookById.Genre}, Price: {foundBookById.Price}");

        Console.WriteLine("\nFind book by Name (Name = 'Journey to the Unknown'):");
        var foundBookByName = library.GetBookByName("Journey to the Unknown");
        if (foundBookByName != null)
            Console.WriteLine($"Id: {foundBookByName.Id}, Name: {foundBookByName.Name}, Genre: {foundBookByName.Genre}, Price: {foundBookByName.Price}");

        Console.WriteLine("\nFind books with Genre 'Nature':");
        var filteredBooksByGenre = library.GetFilteredBooks("Nature");
        foreach (var book in filteredBooksByGenre)
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Genre: {book.Genre}, Price: {book.Price}");

        Console.WriteLine("\nFind books with Price between 10 and 30:");
        var filteredBooksByPrice = library.GetFilteredBooks(10.0, 30.0);
        foreach (var book in filteredBooksByPrice)
            Console.WriteLine($"Id: {book.Id}, Name: {book.Name}, Genre: {book.Genre}, Price: {book.Price}");
    }
}
