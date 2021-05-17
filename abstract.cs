using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracts
{
 public abstract class working
    {
        abstract public void hours(int a);
       
    }
     
   
   public class calculation : working
   {
    public override void hours(int a)
    {
            Console.WriteLine("Total workinghours= 8 hours");
            Console.WriteLine("work done by individual" +a);
            int total = 8 * a;
            Console.WriteLine("Total"+total);


        }


    }

    class datahiding
    {
        private string labourname;
        
        public string Labour
        {
            set
            {
              labourname=value;
            }
            get
            {
                return labourname;
            }

        }

    }
class Program
    {

        static void Main(string[] args)
        {
            calculation ob = new calculation();
            ob.hours(5);
            datahiding data = new datahiding();
            data.Labour = "PRIYA";
            Console.WriteLine(data.Labour);
            Console.ReadKey();
        }
    }
}
