using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace workshop.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            //numarray[10] = 11;                //now we can add


            Log(numarray);
            Console.ReadLine();



        }
        private static void Log(int[] array)
        {
            for(int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}