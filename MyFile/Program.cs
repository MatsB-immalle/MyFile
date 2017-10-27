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
                        ShowAllFilesInCurrentDirectory();
                        break;

                    case "-h":
                        Console.WriteLine("-c = huidige directory");
                        Console.WriteLine("-f = alle files huidige directory, ");
                        Console.WriteLine("-d = alle subdirectories in de huidige directory");                                                
                        break;

                    case "-d":
                        AllSubDirectorysInCurrentDirectory();
                        break;


                    case "-c":
                        CurrentDirectory();
                        break;

                    default:
                        Console.WriteLine("onbekend argument");
                        break;

                }
               
            }
        }

        private static void CurrentDirectory()
        {
            Console.WriteLine("directory " + Environment.CurrentDirectory);
           

        }

        private static void AllSubDirectorysInCurrentDirectory()
        {
            Console.WriteLine("directory d");
        }

        private static void ShowAllFilesInCurrentDirectory()
        {
            Console.WriteLine("alle files in huidige directory");
        }
    }
}
