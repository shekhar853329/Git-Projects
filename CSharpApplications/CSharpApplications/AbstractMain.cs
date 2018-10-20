using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplications
{
    class AbstractMain:Main
    {
        public override void add()
        {
            Console.WriteLine("Method implemented");
        }   
        public static void Main(string[] args)
        {
            AbstractMain a = new AbstractMain();
            a.add();
            Console.ReadLine();
        }    
    }
    public abstract class Main
    {
        public abstract void  add();
    }
}
