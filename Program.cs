using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с символами: ");
            string line = Console.ReadLine();
            char[] lastForest = SubProgramm.LineFromUser(line);

            SubProgramm.MyMatrix();

                     
            Console.ReadKey();
        }
    }
}
