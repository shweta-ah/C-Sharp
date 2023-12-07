using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Lab4
    {
        class bank_account
        {
            public int balance;
            public bool validationCheck(int n)
            {
                if (n > balance)
                {
                    return false;
                }
                else { return true; }
            }
        }
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public string FullCarName
            {
                get { return $"{Make} {Model} {Year}"; }
            }
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
            public string FullNameInUpperCase
            {
                get { return $"{FirstName} {LastName}".ToUpper(); }
            }
        }
        public class Temperature
        {
            public double Celsius { get; set; }

            public Temperature(double celsius)
            {
                Celsius = celsius;
            }

            public double Fahrenheit
            {
                get { return (Celsius * 9 / 5) + 32; }
            }
        }
        public class CustomList<T>
        {
            private T[] items;
            private int count;

            public CustomList()
            {
                items = new T[10];
                count = 0;
            }

            public int Count
            {
                get { return count; }
            }

            public T this[int index]
            {
                get
                {
                    if (index < 0 || index >= count)
                    {
                        throw new IndexOutOfRangeException("Index is out of range");
                    }
                    return items[index];
                }
                set
                {
                    if (index < 0 || index >= count)
                    {
                        throw new IndexOutOfRangeException("Index is out of range");
                    }
                    items[index] = value;
                }
            }

            public void Add(T item)
            {
                if (count == items.Length)
                {
                    Array.Resize(ref items, items.Length * 2);
                }

                items[count] = item;
                count++;
            }
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }
        }

        public class Bookshelf
        {
            private List<Book> books;

            public Bookshelf()
            {
                books = new List<Book>();
            }
            public Book this[string title]
            {
                get
                {
                    return books.Find(book => book.Title == title);
                }
                set
                {
                    Book existingBook = books.Find(book => book.Title == title);
                    if (existingBook != null)
                    {
                        existingBook.Title = value.Title;
                        existingBook.Author = value.Author;
                    }
                    else
                    {
                        books.Add(value);
                    }
                }
            }
        }
        public void Program1()
        {
            bank_account b = new bank_account();
            b.balance = 60000;
            if (b.validationCheck(50000))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void Program2()
        {
            Car myCar = new Car("Toyota", "Camry", 2022);

            Console.WriteLine("Make: " + myCar.Make);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Year: " + myCar.Year);
            Console.WriteLine("Full Car Name: " + myCar.FullCarName);
        }
        public void Program3()
        {
            Person person = new Person("Yashika", "Agrawal");
            Console.WriteLine("Full Name in Uppercase: " + person.FullNameInUpperCase);
        }
        public void Program4()
        {
            Temperature temp = new Temperature(25.0);

            Console.WriteLine("Temperature in Celsius: " + temp.Celsius);
            Console.WriteLine("Temperature in Fahrenheit: " + temp.Fahrenheit);
        }
        public void Program5()
        {
            CustomList<int> myList = new CustomList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine($"Element at index 0: {myList[0]}");
            Console.WriteLine($"Element at index 1: {myList[1]}");
            Console.WriteLine($"Element at index 2: {myList[2]}");
        }
        public void Program7()
        {
            Bookshelf myBookshelf = new Bookshelf();

            myBookshelf["Book1"] = new Book("Book1", "Author1");
            myBookshelf["Book2"] = new Book("Book2", "Author2");
            myBookshelf["Book3"] = new Book("Book3", "Author3");

            Console.WriteLine("Book1: " + myBookshelf["Book1"].Author);
            Console.WriteLine("Book2: " + myBookshelf["Book2"].Author);
            Console.WriteLine("Book3: " + myBookshelf["Book3"].Author);

            myBookshelf["Book1"] = new Book("Updated Book1", "Updated Author1");
            Console.WriteLine("Updated Book1: " + myBookshelf["Updated Book1"].Author);
        }

    }
}
