using System;
using System.Collections.Generic;
namespace GenericList
{
    public class Example : IComparer<int>
    {
        public int Compare(int x, int y)
        {

            return x.CompareTo(y);
        }
        public int Compared(string x, string y)
        {
            return x.CompareTo(y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(1);
            numbers.Add(5);
            numbers.Add(0);
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
//            numbers[7]=21;

            int value = numbers.BinarySearch(0);
            System.Console.WriteLine(value);

var no=numbers.Find(x=>x==2);
int secondexample=numbers.IndexOf(0);

System.Console.WriteLine(secondexample);
            // numbers.Remove(4);
            //    numbers.Sort();
            //    numbers.Reverse();
            List<string> names = new List<string> { "Rahul", "gupta", "Hellow", "h`", "start", "apple" };
            Example obj = new Example();
            // names.Sort();
            numbers.Sort(obj);

            foreach (string i in names)
            {
                System.Console.WriteLine(i);
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
