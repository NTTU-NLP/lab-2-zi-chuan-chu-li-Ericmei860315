using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\admin\Desktop\lab-2-zi-chuan-chu-li-Ericmei860315\Data\Input.txt");
            string line = null;
            while((line = sr.ReadLine()) !=null)
            {
                var lo = line.ToCharArray();
                   
                for (int i = 0; i < lo.Length; i++)
                {
                    if (lo[i].Equals('.') || lo[i].Equals('?') || lo[i].Equals('!'))
                    {
                        Console.WriteLine(lo[i]);
                    }
                    else {
                        Console.Write(lo[i]);                    
                    }
                
                }

            } Console.Read();
        }
    }
}
