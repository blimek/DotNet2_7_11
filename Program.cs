using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę podaj ocenę");
            int ocena = Int32.Parse(Console.ReadLine());

            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celująćy");
                    break;
                default:
                    Console.WriteLine("Podałeś złą ocenę");
                    break;
                    
            }
            Console.ReadLine();

        }
    }
}
