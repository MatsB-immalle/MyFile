using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if( args.Length == 0)
            {
                Console.WriteLine("geef een argument");
            }
            else
            {
                switch (args[0])
                {
                    case "-f":
                        Console.WriteLine("dirrectory f");
                        break;
                    case "-c":
                        Console.WriteLine("dirrectory c");
                        break;
                    default:
                        Console.WriteLine("probeer eens -c of -f");
                        break;

                }
               
            }
        }
    }
}
