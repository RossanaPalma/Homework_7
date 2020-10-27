using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer();
            trip1.Add(50, 10);
            Console.WriteLine("fuel used for trip1 is: " + trip1.mpg());
            Odometer trip2 = new Odometer(50, 10);
            trip2.Add(100, 20);
            Console.WriteLine("fuel used for trip2 is: " + trip2.mpg());
            Console.WriteLine(trip1.toString());
            Console.WriteLine(trip2.toString());
            if (trip1.equals(trip1))
            {
                Console.WriteLine("The two object are the same");
            }
            else
                Console.Write("The two objects are NOT the same");
            //toDo : reset
            //ToDo : test toString();
            //test every method
        }
        public static int add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
