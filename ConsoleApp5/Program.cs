using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primefound = 0;
            int num = 0;

            displayprimearray(primefinder(primefound, num, new int[100]));
            Console.ReadKey();
        }
        static bool primenumber(int num)
        {
            int tocheck = (int)Math.Ceiling(Math.Sqrt(num));

            if (num == 0 || num ==1)
                return false;
            if (num == 2)
                return true;

            for (int x =2; x<= tocheck; x++)
            {
                if(num % x ==0)
                {
                    return false;
                }
            }
            return true;

        }
        static int[] primefinder(int primefound, int num, int[] primearray)
        {
            int total = 0;

            while (total < 100)
            {
                num++;
                if (primenumber(num))
                {
                    if (primefound >= primearray.Length)
                    {
                        break;
                    }
                    primearray[primefound] = num;
                    primefound++;
                }
            }

            return primearray;
        }
        static void displayprimearray(int[] primearracy)
        {
            int space = 0;
            foreach(int prime in primearracy) 
            {
                Console.Write(prime + "\t");
                space++;
                if(space == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    space = 0;
                }
            }
        
        }
    }
}
