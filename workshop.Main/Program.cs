﻿using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace workshop.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strings
            //arrays



            //STRINGS
            string hw = "hello world";
            

            Console.WriteLine(hw.Reverse());
            Console.WriteLine(new string(hw.Reverse().ToArray()));
            Console.WriteLine(Microsoft.VisualBasic.Strings.StrReverse(hw));

            Console.WriteLine(hw.Length);
            Console.WriteLine(hw.Substring(0, 5));

            
            Console.WriteLine(hw.Remove(0, hw.IndexOf(' ')+1));

            //the StringBuilder
            //https://www.dotnetperls.com/stringbuilder




            //ARRAYS
            // 1 declare array 
            int[] numarray = new int[10];

            numarray[0] = 1;
            numarray[1] = 2;
            numarray[2] = 3;
            numarray[3] = 4;
            numarray[4] = 5;
            numarray[5] = 6;
            numarray[6] = 7;
            numarray[7] = 8;
            numarray[8] = 9;
            numarray[9] = 10;



            //numarray[10] = 11;

            //Array.Resize(ref numarray, 11);   //resize array
            //numarray[10] = 11;                //now we can add new element


            LogForeach(numarray);
            
            
            
            
            //2
            string[] zoo = new string[10];
            zoo[0] = "Lion";
            zoo[1] = "Giraffe";
            zoo[2] = "Tarantula";
            zoo[3] = "Ducked Billed Platypus";
            zoo[4] = "Tiger";
            zoo[5] = "Zebra";
            zoo[6] = "Elephant";
            zoo[7] = "Tiger";
            zoo[8] = "Giraffe";
            

            //sorting
            //distinct 

            //foreach (string a in zoo)
            //{
            //    Console.WriteLine(a);
            //}
            
            //foreach (string a in zoo.Distinct())
            //{                
            //    Console.WriteLine(a);
            //}
            //foreach (string a in zoo.OrderBy(d => d))
            //{
            //    Console.WriteLine(a);
            //}
            //foreach (string a in zoo.OrderByDescending(d => d))
            //{
            //    Console.WriteLine(a);
            //}

            foreach(string s in zoo.Distinct().OrderBy(x => x))
            {
                Console.WriteLine(s);
            }

















            Console.ReadLine();










        }


        private static void Log(int[] array)
        {
            for(int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
        private static void LogForeach(int[] array)
        {
            foreach (int i in array)
            {            
                Console.WriteLine(i);
            }
        }
    }
}