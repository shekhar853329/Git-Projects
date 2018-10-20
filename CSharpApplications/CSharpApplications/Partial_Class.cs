using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplications
{
    public class Partial_ClassMain
    {
        public static void Main(string[] args)
        {
            Partial_Class p = new Partial_Class();
            p.FirstName = "shekhar";
            p.LastName = "kumar";
           string fullname= p.Display();
            Console.WriteLine(fullname);
            Console.ReadLine();
        }
    }
}
