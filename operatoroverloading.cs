using System;

namespace operators
{
   class New
    {
        int height, weight;
        
        public  void run()
        {
            
            height = Convert.ToInt32(Console.ReadLine());
            weight = Convert.ToInt32(Console.ReadLine()); 
           
        }
        public static New operator +(New s,New p)
        {
            New r = new New();
            r.height = s.height + p.height;
            r.weight = s.weight + p.weight;
            return r;

        }
        public void show()
        {
            Console.WriteLine("height={0} and weight={1}" , height ,weight);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            New ne1, ne2, ne3;
            ne1 = new New();
            ne2 = new New();
            Console.WriteLine("enter the object1 details");
            ne1.run();
            Console.WriteLine("enter the object2 details");
            ne2.run();
            ne3 = ne1 + ne2;
            Console.WriteLine("displaying ne1 object values");
            ne1.show();
            Console.WriteLine("enter the ne2 object values");
            ne2.show();
            Console.WriteLine("finally both object values are added");
            ne3.show();
            Console.ReadKey();



        }
    }
}
