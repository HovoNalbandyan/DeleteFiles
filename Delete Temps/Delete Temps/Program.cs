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
            
            Console.WriteLine("Do you want to delete temps in C Disc?");
                Console.Write("Press write  Delete =");
            string str2= Console.ReadLine();
           string str1 = "Delete";
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Anahit\Desktop\Desctop\temps\");

            try
            {
                if (str1 == str2)

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
                throw new FieldAccessException();
            }
        }
    }
}
