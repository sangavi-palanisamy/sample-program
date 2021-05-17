using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{ 
    class hospital
    {
        public void details(int id,string name)
        {
            Console.WriteLine("patient details");
            Console.WriteLine(" patient name is "+name);


        }
        public void details(int id, string name,string hosname)
        {
            Console.WriteLine("patient details");
            Console.WriteLine(" doctor name is " + name);
            Console.WriteLine(" hosiptal name is " + hosname);




        }

    }
    public class stay
    {
        public virtual void room(int roomno, int floor)
        {
            Console.WriteLine(" not overide");
        }
    }
   public class rooms:stay
    {
        public override void room(int roomno,int floor)
        {
            Console.WriteLine("OVERRIDE METHOD");
            Console.WriteLine("ROOM NO AND FLOOR "+roomno  +floor);


        }

    }
        
    class Program
    {
        static void Main(string[] args)
        {
            hospital hos = new hospital();
            hos.details(22,"palani");
            hos.details(44,"bala","sudhahospital");

            rooms obj = new rooms();
            obj.room(778,5);
            Console.ReadKey();
        }
    }
}
