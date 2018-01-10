using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] args1 = { "-f", @"D:\elk1\Jsonload.config" };
                System.Diagnostics.Process.Start(@"D:\ELKSoftware\logstash-6.0.0\bin\logstash.bat", String.Join(" ", args1));
               
            }
            catch (Exception ex)
            {
                string a = "";
            }
            
        }

    }
}
