using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysMultiLevelInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Level inheritance");
            Console.WriteLine("Grand Parent Method Summoned");
            GrandParent og = new GrandParent();
            og.Bonjour();
            Console.WriteLine("Parent Method Summoned"); 
            Parent op = new Parent();
            op.Bonjour();
            op.Display();
            Console.WriteLine("Child Method Called");
            Child oc = new Child();
            oc.Bonjour();
            oc.Display();
            oc.Print();

            Console.ReadLine();
        }
    }

    public class GrandParent
    {
        public void Bonjour()
        {
            Console.WriteLine("Hey there Grandson , i am using whatsapp.");
        }
    }

    public class Parent : GrandParent
    {
        public void Display()
        {
            Console.WriteLine("Hi Papa");
        }
            
    }

    public class Child : Parent
    {
        public void Print()
        {
            Console.WriteLine("Hey Papa , Papa Papa");
        }

    }
}
