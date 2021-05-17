using System;

namespace Inherit
{
    public class college
    {
        public string clgname, clgaddress;
      public int clgid,phonenumber;
        public void input()
        {
            Console.WriteLine("Enter the college name");
            clgname = Console.ReadLine();
            Console.WriteLine("Enter the college address");
            clgaddress = Console.ReadLine();
            Console.WriteLine("Enter the college id");
            clgid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the college phone number");
            phonenumber = Convert.ToInt32(Console.ReadLine());
        }


    }
  public class details:college
    {
       
         public void run()
        {
            base.input();
            switch (clgid)
            {
                case 21:
                    Console.WriteLine(clgname);
                    Console.WriteLine("50 rooms are available and fees details please contact the college number");
                    break;
                case 22:
                    Console.WriteLine(clgname);
                    Console.WriteLine("20 rooms are available and fees details please contact the college number");
                    break;
                case 23:
                    Console.WriteLine(clgname);
                    Console.WriteLine("40 rooms are available and fees details please contact the college number");
                    break;
                case 24:
                    Console.WriteLine(clgname);
                    Console.WriteLine("35 rooms are available and fees details please contact the college number");
                    break;
                case 25:
                    Console.WriteLine(clgname);
                    Console.WriteLine("67 rooms are available and fees details please contact the college number");
                    break;
                default:
                    Console.WriteLine("enter the crt college code");
                    break;
            }

        }

      
    }
    public class mess : details
    {

        public void food()
        {
            base.run();
           
            if (clgid == 21)
            {
                Console.WriteLine("mess fees is 60,000 per year");
            }
            else if (clgid == 22)
            {
                Console.WriteLine("mess fees is 50,000 per year");
            }
            else if (clgid == 23)
            {
                Console.WriteLine("mess fees is 70,000 per year");
            }
            else if (clgid == 24)
            {
                Console.WriteLine("mess fees is 90,000 per year");
            }
            else if (clgid == 25)
            {
                Console.WriteLine("mess fees is 1,00,000 per year");
            }
            else
            {
                Console.WriteLine("enter the crt clg id for geeting crt info about mess fee");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            mess ob = new mess();
            ob.food();
            Console.ReadKey();
        }
    }
}
