using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biliárd_git
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> golyók = new List<int>();
            Kezdés(golyók);
            int leeső;           
            do
            {
                leeső=leesősorsoló(golyók);
                Kiíró(golyók);
                Console.WriteLine(leeső);
            } while (leeső!=8);
            if ()
            {
                Console.WriteLine("NYERTÉL");
            }
            Console.ReadKey();
        }

        private static void Kiíró(List<int> golyók)
        {
            foreach (int item in golyók)
            {
                Console.Write($"{item} ");
            }
        }

        private static int leesősorsoló(List<int> golyók)
        {
            Random gép = new Random();
            int szám = gép.Next(golyók.Count);
            golyók.Remove(golyók[szám]);
            return golyók[szám];

        }

        private static void Kezdés(List<int> golyók)
        {           
            for (int i = 1; i <= 15; i++)
            {
                golyók.Add(i); 
            }
        }
    }
}
