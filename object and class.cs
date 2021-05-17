using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_and_class
{

    public class method // default constructor method
    {
       int i, count=0;
       public method()
        {

            for(i=0;i<=20;i++)
            {
              if(i%2==0)
                {
                   
                    count += 1;
                   


                }
            }
            Console.WriteLine("students in even roll number");
            Console.WriteLine(count);
        }
        public method(string staff,int id) // parameterized constructor
        {
            Console.WriteLine("staff NAME IS ");
            Console.WriteLine(staff);
            Console.WriteLine("staff ID IS ");
            Console.WriteLine(id);

        }
        string principle;
        public void method1() // using "this" keyword.
        {
            string principle;
            this.principle = Console.ReadLine();
            principle = Console.ReadLine();

            Console.Write("PRINCIPLE NAME OUTSIDE THE CLASS \t" + this.principle + " \n PRINCIPLE NAME INSIDE THE CLASS \t" + principle);

        }
        int workingdays, totalsalary;
        static int perday = 250; //static variable

        public void salary(string staffna)
        {


            Console.WriteLine("\n");
            Console.WriteLine(staffna);
            
            
            workingdays = Convert.ToInt32(Console.ReadLine());
            totalsalary = workingdays * perday;
            Console.WriteLine(totalsalary);

        }
    }
    public struct students // struct method
    {
        public int rollno,mark1,mark2,total;
       public void display(int roll,int m1,int m2)
        {
            total = m1 + m2;
            Console.WriteLine("total \t" + total);

        }
    }
    public enum receptionalistid // enum method
    {
        mba=1,mca,bsc,ft,mech,civil
    }
    class Program
    {
        static void Main(string[] args)
        {
            method obj = new method();
            string staffname;
            staffname= Console.ReadLine();
            int staffid = Convert.ToInt32(Console.ReadLine());


            method ob = new method(staffname,staffid);
            ob.method1();
            ob.salary(staffname);

            students stu = new students();
            stu.rollno = 20;
            stu.mark1 = 80;
            stu.mark2 = 90;
            Console.WriteLine("rollno \t"+stu.rollno);
            stu.display(stu.rollno,stu.mark1,stu.mark2);


            int x = (int)receptionalistid.bsc;
            int y = (int)receptionalistid.mech;
            Console.WriteLine("BSC ="+x);
            Console.WriteLine("MECH ="+y);
            Console.ReadKey();

        }
    }
}
