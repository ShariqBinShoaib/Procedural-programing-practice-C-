using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBall
{
    class Program
    {
        static void Main(string[] args)
        {

            int oversize = 6, runs = 0;
            Console.WriteLine("Enter the number of overs");
            int overs = Convert.ToInt32(Console.ReadLine());
            string[][] jag = new string[overs][];
            int[] overruns = new int[jag.Length];

            for (int i = 0; i < jag.Length; i++)
            {
                jag[i] = new string [oversize];
                Console.WriteLine("Enter score for {0} over",i+1);
                for (int j = 0; j < jag[i].Length; j++)
                {
                    jag[i][j] = Console.ReadLine();
                    if (jag[i][j] == "n" || jag[i][j] == "N")
                    {
                        Array.Resize<string>(ref jag[i], ++oversize);
                        runs++;
                        overruns[i]++;
                    }
                    else
                    {
                        runs += Convert.ToInt32(jag[i][j]);
                        overruns[i] += Convert.ToInt32(jag[i][j]);
                    }
                } // j loop end
                
                oversize = 6;

            } // i loop end

            for (int i = 0; i < jag.Length; i++)
            {
                Console.Write("Over " +(i+1)+": ");
                for (int j = 0; j < jag[i].Length; j++)
                {
                    Console.Write(jag[i][j] +" ");
                }
                Console.Write("\tTotal Runs: "+ overruns[i]);
                Console.WriteLine();
            }
            
            Console.WriteLine("Total Score: "+runs);

        }
    }
}
