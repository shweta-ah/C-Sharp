using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Lab1
    {
        public void program1()
        {
            int[] arr = new int[] { 10, 20, 30, 22, 9, 15 };
            int sum = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            System.Console.WriteLine("sum of number present in array is:" + sum);
        }
        public void program2()
        {
            int[] arr = { 1, 2, 6, 2, 18 };

            int i = 0;
            int sum = 0;
            float average = 0.0F;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = (float)sum / arr.Length;

            Console.WriteLine("Average of Array elements: " + average);
        }
        public void program3()
        {
            int[] sourceArray = new int[] { 10, 1, 48, 12 };
            int maxElement = 0;
            for (int index = 0; index < sourceArray.Length; index++)
            {
                if (sourceArray[index] > maxElement)
                {
                    maxElement = sourceArray[index];
                }

            }
            System.Console.WriteLine(maxElement);
        }
        public void program4()
        {
            int[] arr = new int[] { 10, 20, 30, 22, 9, 15 };
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount += 1;
                }
                else
                {
                    oddCount += 1;
                }
            }
            System.Console.WriteLine("even Count:" + evenCount);

            System.Console.WriteLine("odd Count:" + oddCount);

        }
        public void program5()
        {
            int[] arr = { 5, 2, 8, 1, 9, 3 };

            Console.WriteLine("Original array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nArray in reverse order:");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public void program6()
        {
            int[] arr = new int[] { 10, 20, 30 };
            int factor = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * factor;
            }
            System.Console.WriteLine("after multiplication:-");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        public void program7()
        {
            int[] arr = { 5, 2, 8, 1, 9, 3 };

            Console.Write("Enter the number to search for: ");
            int target = int.Parse(Console.ReadLine());

            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine($"The number {target} was found at index {index}.");
            }
            else
            {
                Console.WriteLine($"The number {target} was not found in the array.");
            }
        }
        public void program8()
        {
            int[] numbers = { 5, 2, 8, 1, 9, 3 };

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            if (secondSmallest == int.MaxValue)
            {
                Console.WriteLine("There is no second smallest number.");
            }
            else
            {
                Console.WriteLine("The second smallest number is: " + secondSmallest);
            }
        }
        public void program9()
        {
            int[] arr = { 5, 2, 8, 1, 9, 3, 2, 5, 8 };

            int[] uniqueNumbers = arr.Distinct().ToArray();

            Console.WriteLine("Original array:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nArray with duplicates removed:");
            foreach (int num in uniqueNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public void program10()
        {
            int[] array1 = { 5, 2, 8, 1, 9 };
            int[] array2 = { 3, 8, 5, 4, 6 };

            int maxSize = Math.Max(array1.Length, array2.Length);
            int[] common = new int[maxSize];
            int commonCount = 0;

            foreach (int num1 in array1)
            {
                foreach (int num2 in array2)
                {
                    if (num1 == num2)
                    {
                        common[commonCount] = num1;
                        commonCount++;
                        break; // Move to the next number in the outer loop
                    }
                }
            }

            // Create a new array with only the common elements
            int[] result = new int[commonCount];
            Array.Copy(common, result, commonCount);

            Console.WriteLine("Array 1:");
            foreach (int num in array1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nArray 2:");
            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nCommon elements:");
            foreach (int num in common)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
