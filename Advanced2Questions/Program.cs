using System;
using System.Collections;
using System.Collections.Generic;

namespace Advanced2Questions
{
    internal class Program
    {
        static void RemoveOdd(ArrayList Numbers)
        {

            for (int i = 0; i < Numbers.Count; i++)
            {
                if ((int)Numbers[i] % 2 != 0)
                {
                    Numbers.RemoveAt(i);

                }
            }
        }

        static void StackSearch(Stack<int> Stack, int target)
        {
            int Count = 0;
            while (Stack.Count > 0)
            {
                int Current = Stack.Pop();
                Count++;
                if (target == Current)
                {
                    Console.WriteLine($"Target  found after count of  {Count} ");
                    return;
                }
            }
            Console.WriteLine("Target not found");
        }

        static List<int> FindIntersection(List<int> list1, List<int> list2)
        {
            List<int> Intersected = new List<int>();
            foreach (int num in list1)
            {
                if (list2.Contains(num))
                {
                    Intersected.Add(num);
                }
            }
            return Intersected;
        }

        static ArrayList ContagiuousSum(ArrayList arraylist, int target)
        {
            for (int i = 0; i < arraylist.Count; i++)
            {
                int currentSum = 0;
                ArrayList sumArray = new ArrayList();
                for (int j = i; j < arraylist.Count; j++)
                {
                    currentSum += (int)arraylist[j];
                    sumArray.Add(arraylist[j]);
                    if (currentSum == target)
                    {
                        return sumArray;
                    }
                }
            }
            return new ArrayList(); // Empty ArrayList if not found
        }

        static Queue<int> ReverseKqueue(Queue<int> queue, int k) // 1 2 3 4 5
        {
            // 1 ,2 3, 4 ,5
            Stack<int> stack = new Stack<int>();    
            for(int i=0;i<k;i++)
            {
                stack.Push(queue.Dequeue()); // 1 2 3
            }
            while (k > 0)  // while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            foreach (int num in queue)
            {
                Console.WriteLine(num);
            }
            int remainingCount = queue.Count - k;
            for (int i = 0; i < remainingCount; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            return     queue;
        }
        static void Main(string[] args)
        {

            #region Question 1: Given an array consists of numbers with size N and number of queries,

            Console.WriteLine("Enter the size array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of queries");
            int noOfQueries = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < noOfQueries; i++)
            {
                Console.WriteLine("Enter vlue of queey");
                int q11 = int.Parse(Console.ReadLine());
                int count = 0;
                foreach (int num in arr)
                {
                    if (num > q11)
                        count++;
                }
                Console.WriteLine(count);
            }

            #endregion
            Console.WriteLine("===================");
            #region   Question 2: Given a number N and an array of N numbers, determine if it's a palindrome or not.


            Console.WriteLine("Enter size of array");
            int size1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size1];
            Console.WriteLine("Enter array elements");
            bool isPalindrome = true;
            for (int i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size1 / 2; i++)
            {
                if (arr1[i] != arr1[size1 - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine($"Is palindrome: {isPalindrome}");
            #endregion
            Console.WriteLine("===================");

            #region Question 3: Given a Queue, implement a function to reverse the elements of a queue using a stack.
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(3);
            q1.Enqueue(5);
            q1.Enqueue(7);
            q1.Enqueue(9);

            Stack<int> stack = new Stack<int>();
            while (q1.Count > 0)
            {
                stack.Push(q1.Dequeue());
            }

            Console.WriteLine("\nReversed Queue:");
            foreach (int num in stack)
            {
                Console.WriteLine(num);
            }
            #endregion
            Console.WriteLine("===================");


            #region  Question 4: Given an ArrayList, implement a function to remove all odd numbers from it.
            ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8 };
            RemoveOdd(numbers);
            Console.WriteLine("Array after removing odd numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            #endregion
            Console.WriteLine("===================");

            #region Question 5: Implement a queue that can hold different data types.
            Queue<object> q2 = new Queue<object>();
            q2.Enqueue(1);
            q2.Enqueue("Mira");
            q2.Enqueue(5.28);
            Console.WriteLine("===================");
            #endregion
            Console.WriteLine("===================");

            #region Question 6: Create a function that pushes a series of integers onto a stack.  Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found.


            Console.WriteLine("Enter the number of elements");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter values of stack");
            Stack<int> stack2 = new Stack<int>();
            for (int i = 0; i < no; i++)
            {
                int num = int.Parse(Console.ReadLine());
                stack2.Push(num);
            }
            Console.WriteLine("Enter your target");
            int target = int.Parse(Console.ReadLine());
            StackSearch(stack2, target);
            #endregion;

            Console.WriteLine("===================");

            #region Question 7: Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            Console.WriteLine("Enter the size of array 1");
            int sizeArr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of array 2");
            int sizeArr2 = int.Parse(Console.ReadLine());

            List<int> array1 = new List<int>();
            Console.WriteLine("Enter elements of array 1");
            for (int i = 0; i < sizeArr1; i++)
            {
                array1.Add(int.Parse(Console.ReadLine()));
            }

            List<int> array2 = new List<int>();
            Console.WriteLine("Enter elements of array 2");
            for (int i = 0; i < sizeArr2; i++)
            {
                array2.Add(int.Parse(Console.ReadLine()));
            }

            List<int> intersection = FindIntersection(array1, array2);
            Console.WriteLine("Arrays Intersection");
            foreach (int num in intersection)
            {
                Console.WriteLine(num);
            }
            #endregion
            Console.WriteLine("===================");
            Console.WriteLine("===================");
            Console.WriteLine("===================");

            #region Question 8: Given an ArrayList of integers and a target sum, find if there is a contiguous sublist that sums up to the target.

            ArrayList arrayList1 = new ArrayList();
            Console.WriteLine("Enter size of ArrayList");
            int sizeOfArrayList = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter arraylist elemnets");
            for (int i = 0; i < sizeOfArrayList; i++)
            {
                arrayList1.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter target sum:");
            int targetSum = int.Parse(Console.ReadLine());
            ArrayList sumArray = ContagiuousSum(arrayList1, targetSum);

            Console.WriteLine("ssumArray");
            foreach (int num in sumArray)
            {
                Console.WriteLine(num);
            }


            #endregion


            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
            //  Queue<int> q = new Queue<int>();
            Queue<int> q = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Enter  number of elements you want to reverse:");
            int k = int.Parse(Console.ReadLine());
            // 1 2 3 4 5 
            // 1 2 3 4 5
            Queue<int> ReversedQueue = ReverseKqueue(q, k);
            foreach (int num in ReversedQueue)
            {
                Console.WriteLine(num);
            }
            #endregion
        }
        }
    }