using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\My project";
            string[] folders = Directory.GetDirectories(path);
            Console.WriteLine("Folders and files:\n");

            foreach (string p in folders)
            {
                Console.WriteLine(p);
                string subname = p;
                DirectoryInfo fullnameSub = new DirectoryInfo(subname);
                foreach (var file in fullnameSub.GetFiles())
                {
                    Console.WriteLine(file);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}