using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp { 
        public class Employee
    {
        public int age;
        public string name;
        public int salary;

        public void getDetails()
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("salary: " + this.salary);
            Console.WriteLine("age: " + this.age);
        }
    }
    public class BankAccount
    {
        public String name;
        public int Account_no;
        public double balance;

        public void deposit(int amt)
        {
            balance += amt;
        }

        public void withdraw(int amt)
        {
            balance -= amt;
        }

        public void display()
        {
            Console.WriteLine(balance);
        }
    }
    public static class MathHelper
    {
        public static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) { sum += arr[i]; }
            return sum / arr.Length;
        }
    }
    public class Logger
    {
        public static void LogMessage()
        {
            Console.WriteLine("Hello!");
        }
    }
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    public abstract class Animal
    {
        public string Name;
        public int Age;


        public abstract void MakeSound();
    }

    // Derived class for Dog
    public class Dog : Animal
    {

        public Dog(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof woof!");
        }

        public void Fetch()
        {
            Console.WriteLine("Dog fetches the ball.");
        }
    }

    // Derived class for Cat
    public class Cat : Animal
    {
        public Cat(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows: Meow meow!");
        }

        public void Climb()
        {
            Console.WriteLine("Cat climbs a tree.");
        }
    }
    public class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped.");
        }
    }

    public sealed class Car : Vehicle
    {
        // Additional properties and methods specific to Car can be added here
    }
   

    class BankAccount2
    {
        public string AccountNumber { get; }
        public double Balance { get; protected set; }

        public BankAccount2(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }

    sealed class SavingsAccount : BankAccount2
    {
        public double InterestRate { get; }

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }
        public void CalculateInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;
            Console.WriteLine($"Interest calculated: {interest:C}. New balance: {Balance:C}");
        }
    }
    internal class Lab2
    {
        


        public void Program1()
        {
            Employee e = new Employee();
            e.age = 22;
            e.salary = 500000;
            e.name = "Test";
            e.getDetails();
        }
        public void Program2()
        {
            BankAccount account = new BankAccount();
            account.name = "Test";
            account.Account_no = 1;
            account.balance = 20000;
            account.deposit(10000);
            account.withdraw(5000);
            account.display();
        }
        public void Program3()
        {
 
            Console.WriteLine(MathHelper.CalculateAverage(new int[] { 1, 2, 3, 4, 5, }));
        }
        public void Program4()
        {
            Logger.LogMessage();
        }
        public void Program5()
        {
            person p = new person();
            p.fn = "Yashka";
            p.ln = "Agrawal";
            p.PrintFullName();
        }
        public void Program6()
        {
            Employee2 e1 = new Employee2();
            e1.dep = "CS";
            Employee2 e2 = new Employee2();
            e2.dep = "Mech";
            e1.CalculateSalary();
            e2.CalculateSalary();
            e1.DisplaySalary();
            e2.DisplaySalary();
        }
        public void Program7()
        {
            Circle c = new Circle(10);
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(r.CalculateArea());
        }

        public void Program8()
        {
            Console.WriteLine("Select an animal:");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of the animal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the age of the animal: ");
            int age = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Dog dog = new Dog(name, age);
                dog.MakeSound();
                dog.Fetch();
            }
            else if (choice == 2)
            {
                Cat cat = new Cat(name, age);
                cat.MakeSound();
                cat.Climb();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        public void Program9()
        {
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();
        }
        public void Program10()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter interest rate (%): ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            SavingsAccount savingsAccount = new SavingsAccount(accountNumber, initialBalance, interestRate);

            Console.WriteLine($"Initial balance: {savingsAccount.Balance:C}");

            savingsAccount.CalculateInterest();
            Console.WriteLine($"Balance after interest: {savingsAccount.Balance:C}");
        }
    }
}
