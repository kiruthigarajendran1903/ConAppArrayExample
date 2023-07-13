using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array introduction
            /* int[] marks = new int[5];
             Console.WriteLine("Enter Marks");
             for (int i = 0; i < marks.Length; i++)
             {
                 Console.WriteLine("Enter marks in subject" + (i + 1));
                 marks[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("*Marks list*");
             for (int i = 0; i < marks.Length; i++)
             {
                 Console.WriteLine($"Subject {i + 1} \t Marks:{marks[i]}");*/


            //ore defined array
            /* int[] marks = { 12, 24, 45, 67 };
             int[] Marks = new int[4] { 12, 34, 1, 1 };
             Console.WriteLine("*marks list*");
             for (int i = 0; i < marks.Length; i++)
             {
                 Console.WriteLine($"Subject {i+1} \t  Marks:{Marks[i]}");
             }*/


            Console.WriteLine("Enter Number of students");
            int nos = int.Parse(Console.ReadLine());
            string[] students = new string[nos];
            for (int i = 0; i < nos; i++)
            {
                Console.WriteLine($"Enter Student{i + 1}\'s name");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("List of studnets");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
    }

