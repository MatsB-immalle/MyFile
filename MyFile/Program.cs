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

                    case "-h":
                        Console.WriteLine("-c=huidige directory");
                        Console.WriteLine("-f = alle files huidige directory, ");
                        Console.WriteLine("-d= alle subdirectories in de huidige directory");                                                
                        break;

                    case "-d":
                        Console.WriteLine("dirrectory d");
                        break;


                    case "-c":
                        Console.WriteLine("dirrectory c");
                        break;

                    default:
                        Console.WriteLine("onbekend argument");
                        break;

                }
               
            }
        }
    }
}
