using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Advanced2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region NonGeneric ArrayList  (Create new array each Time)
            //Onjects
            //ArrayList arr=new ArrayList();
            //Console.WriteLine(arr.Count);
            //Console.WriteLine(arr.Capacity);
            //arr.Add(0);
            //arr.Add(1);
            //Console.WriteLine(arr.Count);
            //Console.WriteLine(arr.Capacity);
            //arr.Add(0);
            //arr.Add(1);
            //Console.WriteLine(arr.Count);
            //Console.WriteLine(arr.Capacity);
            //arr.AddRange(new int[] { 1, 2, });
            //Console.WriteLine(arr.Count);
            //Console.WriteLine(arr.Capacity);
            //arr.TrimToSize(); //Count=Capacity
            //Console.WriteLine(arr.Count);
            //Console.WriteLine(arr.Capacity);
            //ArrayList ar = new ArrayList();
            ////ArrayList implements Ienumerable merabes that is why i can use for each
            //for(int i = 6;i<=22;i++)
            //{
            //    ar.Add(i);
            //}
            //Console.WriteLine(ar.Count);
            //Console.WriteLine(ar.Capacity);
            #endregion

            #region Non Generic cons
            //Boxing,unboxing
          //;ar.Add("mira"); //error at runtime 
            //benefit of arraylit to hold elements of alot of types 
            //arr.Add(9.8);
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            #endregion
            Console.WriteLine("=======================");

            #region Generic collection  list<t>
            //List<int>Numbers=new List<int>();
            //Console.WriteLine(Numbers.Count);
            //Console.WriteLine(Numbers.Capacity);
            //Numbers.Add(1);
            //Numbers.EnsureCapacity(21);
            //Console.WriteLine(Numbers.Count);
            //Console.WriteLine(Numbers.Capacity);
            //Numbers.TrimExcess();
            //#endregion
            //Console.WriteLine("=======================");
            //#region List funtionns
            //Numbers.Insert(0, 1);
            //Numbers.InsertRange(1, [101, 102, 105]);
            //foreach (int num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //int index = Numbers.BinarySearch(-10);
           // Console.WriteLine(index);
          
            #endregion
            Console.WriteLine("=======================");

            #region Binary Search
            List<Employee> employees = new List<Employee>();
            {
                new Employee(10, "Mira", 89000);
                new Employee(20, "Dina", 890);
                new Employee(30, "Hesham", 8900);
                new Employee(40, "Joseh", 8000);

            }
            int index = employees.BinarySearch(new Employee() { Id=20 });
            //another overload for binary Search
          //employees.Sort(EmployeeComparer);
            Console.WriteLine(index);
            #endregion

            #region Generic Methods
            List<int>Numbers=new  List<int> (5){ 1,2,3,4,5,6};
            int evenNumber = Numbers.Find((N) => N % 2 == 0);

            int indexx =Numbers.FindIndex (N => N % 2 == 0);
            int[]EvenNumbers=Numbers.FindAll(N=>N%2 == 0).ToArray();
            foreach(int even in EvenNumbers)
            {
                Console.WriteLine(even);
            }

            #endregion

            Console.WriteLine("=======================");
            #region Linked list
            LinkedList<int>numbers=new LinkedList<int>();
            LinkedListNode<int> Node = numbers.AddFirst(1);
            LinkedListNode<int> Node3 = numbers.AddAfter(Node, 3);
            Console.WriteLine(Node.Value);
            Console.WriteLine(Node.ValueRef);
            Console.WriteLine(Node3.Value);
            Console.WriteLine(Node3.ValueRef);
            Console.WriteLine(Node.Next.ValueRef);


            //adding more tha searching (linkedist)
            //searching moethan adding (list)
            //string builder linked list


            #endregion
            Console.WriteLine("=======================");
            #region stack generic
            Stack<int> st1=new Stack<int>();
            st1.Push(1);
            st1.Push(2);
            st1.Push(3);
            Console.WriteLine(st1.Pop());
            Console.WriteLine("=======================");
            Console.WriteLine(st1.TryPeek(out int value04));
            foreach (int num in st1)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(st1.TryPop(out int value00));
            Console.WriteLine(st1.TryPop(out int value01));
            Console.WriteLine(st1.TryPop(out int value02));
            Console.WriteLine(st1.TryPop(out int value03));
            #endregion
            Console.WriteLine("=======================");

            #region queue 
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.TryDequeue(out int value005));
            Console.WriteLine(value03); //int
            #endregion
        }
    }
}
