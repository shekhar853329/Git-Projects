using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplications
{
    class Program
    {
        static void arrayMethod(int[] a)
        {
            int[] b = new int[5];
            a = b;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arrayMethod(arr);
            Console.WriteLine(arr.Length);

        }
    }
}
