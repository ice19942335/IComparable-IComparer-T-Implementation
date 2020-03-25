using System;

namespace IComparable_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arr = new Person[10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Person(rnd.Next(1, 95), rnd.Next(30, 190), rnd.Next(20, 95));
                Console.WriteLine("Age: {0}, Height: {1}, Weight: {2}", arr[i].Age, arr[i].Height, arr[i].Weight);
            }

            //Array.Sort(arr);
            Array.Sort(arr, new HeightComparer());

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Age: {0}, Height: {1}, Weight: {2}", arr[i].Age, arr[i].Height, arr[i].Weight);
            }
        }
    }
}
