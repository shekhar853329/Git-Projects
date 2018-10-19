using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplications
{
    class Parameter_Param
    {
        public static void Main(string[] args)
        {
            Parameter_Param p = new Parameter_Param();
            p.print(2, 3, 8);
            int[] arr = { 2, 11, 15, 20 };
            p.print(arr);
            Console.ReadLine();
        }
        public void print(params int[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
