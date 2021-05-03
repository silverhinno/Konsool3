using System;
using System.Collections.Generic;

namespace Tunnitöö5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] array = { "H", "e", "l", "l", "o" };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //foreach (var ch in array)
            //{
            //    Console.WriteLine(ch);
            //}

            //string[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f" };

            //int female = 0, male = 0;
            //int result = 0;

            //foreach (var gender in genders)
            //{
            //    //if (gender == "f")
            //    //{
            //    //    female++;
            //    //}
            //    //if (gender == "m")
            //    //{
            //    //    male++;
            //    //}

            //    result = gender == "f" ? female++ : male++;
            //}

            //Console.WriteLine("Number of females = {0}", female);
            //Console.WriteLine("Number of males = {0}", male);




            //Console.WriteLine("foreach loop sample");

            //int[] oddArray = new int[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            //foreach (var num in oddArray)
            //{
            //    Console.WriteLine(num);

            //    if (num == 14)
            //    {
            //        break;
            //    }
            //}

            //for (int i = 1; i < (99 + 1); i++)
            //{
            //    if (i <= 14)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            Console.WriteLine(i.ToString());
            //        }
            //    }
            //}



            //var parts = new List<Part>()
            //{
            //    new Part() {Id = 1, PartName = "crank arm"},
            //    new Part() {Id = 2, PartName = "chain ring"},
            //    new Part() {Id = 3, PartName = "regular seat"},
            //    new Part() {Id = 4, PartName = "banana seat"},
            //    new Part() {Id = 5, PartName = "casette"},
            //    new Part() {Id = 6, PartName = "shift lever"}
            //};

            //foreach (var part in parts)
            //{
            //    Console.WriteLine("Id is {0} and description is {1}", part.Id, part.PartName);
            //}






            //Console.WriteLine("Kirjuta number, et kui pikk peaks olema korrutustabel");
            //Console.WriteLine("-----------------------------------------------------");

            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Korrutustabel 1 kuni {0}", n);

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j <= n-1)
            //        {
            //            Console.Write("{0}x{1} = {2} ", j, i, i*j);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0}x{1} = {2} ", j, i, i * j);
            //        }
            //        Console.Write("\n");
            //    }
            //}



            Console.WriteLine("Kirjuta numbripüramiidi suurus");
            Console.WriteLine("-----------------------------------------------------");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");

            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", j);
                }
                Console.Write("\n");
            }
        }
        //public class Part
        //{
        //    public int Id { get; set; }
        //    public string PartName { get; set; }
        //    }
        //}

    }
}
