using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> customers = new MyDictionary<string>();
            customers.Add("Sabır");
            customers.Add("Sabır");
            customers.Add("Sabır");
            customers.Add("Sabır");
            customers.Add("Sabır");

            foreach (var array in customers.Arrays)
            {
                Console.WriteLine(array);
            }
        }
    }
}
