using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplications
{
    public class Delegate
    {
        public delegate int DelegateExmple(int a, int b);
        public static void Main()
        {
            Delegate del = new Delegate();
            DelegateExmple dobj = del.add;
            Console.WriteLine(dobj(5, 3));
            dobj = del.delete;
            Console.WriteLine(dobj(5, 3));
            Console.ReadLine();
        }
        public int add (int a, int b)
        { return a + b; }
        public int delete(int a,int b)
        {
            return a-b;
        }
    }
}
