using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Lab5
    {
        public class CustomException : Exception
        {
            // You can add custom properties and constructors to your exception
            public CustomException() { }

            public CustomException(string message) : base(message) { }
        }
        public void program1()
        {
            try
            {
                int a = 9;
                Console.WriteLine(a / 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void program2()
        {
            try
            {
                int[] arr= new int[9];
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void program3()
        {
            try {
                string s = "Yashika";
                int a = int.Parse(s);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void program4()
        {
            try
            {
                throw new CustomException("This is a custom exception.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom Exception caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other Exception caught: " + ex.Message);
            }
        }
        public void program5()
        {
            try
            {
                int[] arr = new int[9];
                Console.WriteLine(arr[10]);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Program6()
        {
            try
            {
                Console.WriteLine("Outer try block started.");
                try
                {
                    Console.WriteLine("Inner try block started.");
                    throw new CustomException("Exception in the inner block.");
                }
                catch (CustomException innerException)
                {
                    Console.WriteLine("Caught CustomException in inner block: " + innerException.Message);
                }
                finally
                {
                    Console.WriteLine("Inner finally block executed.");
                }
                Console.WriteLine("After inner try-catch-finally in the outer block.");
            }
            catch (CustomException outerException)
            {
                Console.WriteLine("Caught CustomException in outer block: " + outerException.Message);
            }
            finally
            {
                Console.WriteLine("Outer finally block executed.");
            }

            Console.WriteLine("After outer try-catch-finally.");
        }

        public void Program7()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the numerator: ");
                    int numerator = int.Parse(Console.ReadLine());

                    Console.Write("Enter the denominator: ");
                    int denominator = int.Parse(Console.ReadLine());

                    if (denominator == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }

                    int result = DivideNumbers(numerator, denominator);
                    Console.WriteLine($"Result of division: {result}");

                    break; // Exit the loop if division is successful
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }

            Console.WriteLine("Program continues after division.");
        }
        public int DivideNumbers(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public void GenerateException()
        {
            try
            {
                throw new CustomException("Original exception in GenerateException");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Caught and rethrown in GenerateException: {ex.Message}");
                throw;
            }
        }
        public void Program8() {
            try
            {
                GenerateException();
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Caught and handled in Main: {ex.Message}");
            }

            Console.WriteLine("Program continues after exception handling.");
        }

        public class NegativePriceException : Exception
        {
            public NegativePriceException(string message) : base(message)
            {
            }
        }

        public class PriceTooHighException : Exception
        {
            public PriceTooHighException(string message) : base(message)
            {
            }
        }
        public int ValidateAndAddToCart(string userInput)
        {
            if (!int.TryParse(userInput, out int price))
            {
                throw new FormatException();
            }

            if (price < 0)
            {
                throw new NegativePriceException("Negative prices are not allowed.");
            }

            if (price > 10000)
            {
                throw new PriceTooHighException("Price exceeds the maximum allowed value.");
            }

            return price;
        }

        public int CalculateTotalPrice(int[] cart, int itemCount)
        {
            int totalPrice = 0;
            for (int i = 0; i < itemCount; i++)
            {
                totalPrice += cart[i];
            }
            return totalPrice;
        }
        public void Program10()
        {
            int[] shoppingCart = new int[100];
            int cartIndex = 0;

            Console.WriteLine("Welcome to the Simple E-Commerce Application");

            while (true)
            {
                try
                {
                    Console.Write("Enter the price of the item (or 'done' to finish): ");
                    string userInput = Console.ReadLine();

                    if (userInput.ToLower() == "done")
                    {
                        break;
                    }

                    int price = ValidateAndAddToCart(userInput);
                    shoppingCart[cartIndex++] = price;
                }
                catch (NegativePriceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a valid price.");
                }
                catch (PriceTooHighException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }

            int totalPrice = CalculateTotalPrice(shoppingCart, cartIndex);
            Console.WriteLine($"Total Price of Items in the Cart: {totalPrice:C}");

            Console.WriteLine("Thank you for using the Simple E-Commerce Application!");
        }
    }
}
