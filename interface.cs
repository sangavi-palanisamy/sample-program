using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface inter1
    {
        void method(int a,string s);
        
        
    }
    class sample:inter1
    {
        public void method(int a,string s)
        {
            Console.WriteLine("the id \t {0}  and name \t{1}", a ,s);
        }
    }
    class sample1:inter1
    {
        public void method(int a,string s)
        {
         Console.WriteLine("the id \t {0}  and name \t{1}", a, s);  
            

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            inter1 ne = new sample();
            ne.method(20,"sangavi");
            inter1 ne1 = new sample1();
            ne1.method(40,"bavi");
            Console.ReadKey();
        }
    }
}
