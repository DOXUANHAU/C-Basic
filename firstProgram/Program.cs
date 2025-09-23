using System;
using System.Diagnostics;
using System.Numerics;
using System.Threading;

namespace algorithms
{
    class Program
    {

        // Write a program to compute the factorial of a given non-negative integer using both iterative and recursive approaches.
        public BigInteger factorialIterative(int n)
        {
            // check n < 0 or n =0 return -1 as error
            if (n < 0) return -1;
            if (n < 2) return 1;
            BigInteger result = new BigInteger(1);
            for (int i = n; i >= 2; i--)
            {
                result *= i;
            }
            return result;
        }
        public BigInteger factorialRecursive(int n)
        {
            if (n < 0) return -1;
            if (n < 2) return 1;
            return n * factorialRecursive(n - 1);
        }
        //         Write a program to determine if a given number is prime.

        public bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n % 2 == 0) return n == 2;
            int i = 3;
            while (i * i <= n)
            {
                if (n % i <= 0) return false;
                i += 2; 
            }
            return true;
        }

        // Write a program to reverse a given string without using built-in methods like Array.Reverse.
        public string reverseString(string s)
        {
            char[] arr = s.ToCharArray();
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            return new string(arr);
        }

        // Write a program to calculate the sum of all elements in an integer array.
        public int sumArray(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        // Generate the first n numbers in the Fibonacci sequence.
        // Write a program to check if a string is a palindrome, ignoring spaces, punctuation, and case.
        // Implement the bubble sort algorithm to sort an array of integers in ascending order.
        // Compute the Greatest Common Divisor (GCD) of two numbers using the Euclidean algorithm.
        // Write a program to count the number of vowels (a, e, i, o, u) in a given string, ignoring case.
        // Implement the binary search algorithm to find an element in a sorted array and return its index or indicate if it’s not found.



        // write a higher order function that calculate the finished time as a mili second 
        public (BigInteger result, long time) MeasureExecutionTime(Func<int, BigInteger> func, int input)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            BigInteger result = func(input);
            stopwatch.Stop();

            return (result, stopwatch.ElapsedMilliseconds);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.MeasureExecutionTime(p.factorialIterative, 0));
            Console.WriteLine(p.MeasureExecutionTime(p.factorialRecursive, 0));
            Console.WriteLine(p.reverseString("Hello, World!"));

        }
    }

}