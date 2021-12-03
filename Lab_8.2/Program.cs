using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\tmp\\lab_8.1.txt";

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter info = new StreamWriter(path))
            {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    info.WriteLine(r.Next(0, 1000));
                }
            }
            int[] arraySum = new int[10];
            int sum = 0;
            using (StreamReader info = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    arraySum[i] = Convert.ToInt32(info.ReadLine());
                    sum += arraySum[i];
                }
            }
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadKey();
        }
    }
}