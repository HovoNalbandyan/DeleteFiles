using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delete_Temps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine("Do you want to delete temps in C Disc?");
            //Console.Write("Press write  Delete =");
            string str2= Console.ReadLine();
            string str1 = "Random Numbers";
            string str3;
            int n = 3000;
            double[] x = new double[n];
            Random rnd = new Random();
            str3 = rnd.Next(1000, 3000).ToString();
            Console.WriteLine(str3);
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Anahit\Desktop\Desctop\temps\");

            try
            {
                if (str3 == str1)

                {
                    FileInfo[] arr = di.GetFiles();
                    foreach (FileInfo file in arr)
                    {
                        file.Delete();
                    }
                }
            }
            catch
            {
                //throw new FieldAccessException();
            }
        }
    }
}
