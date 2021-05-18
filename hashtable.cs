using System;
using System.Collections;

namespace hashtable
{
    class class1
    {
        public void run()
        {
            Hashtable ne = new Hashtable();
            ne.Add("ps", "sangavi");
            ne.Add("bl", "bavi");
            ne.Add(1, 29);
            ne.Add(2, 79.90);
            foreach(DictionaryEntry item in ne)
            {
                Console.WriteLine("key:{0} , value:{1}", item.Key, item.Value);
            }
            foreach (var sample in ne.Keys)
            {
                Console.WriteLine("key:{0}", sample);
            }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {

            class1 ob = new class1();
            ob.run();
            Console.ReadKey();
        }
    }
}
