using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FilesHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path: ");
            string userPath = Console.ReadLine();
            if (!Directory.Exists(userPath))
            {
                Directory.CreateDirectory(userPath);
            }

            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter text: ");

            string text = Console.ReadLine();
            try
            {
                using (StreamWriter sw = new StreamWriter(userPath+"\\"+fileName, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
