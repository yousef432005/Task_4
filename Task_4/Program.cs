using System;
using Task_4;

namespace CIS
{
    class program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota","Corolla",2024);
            car1.DisplayInfo();

            Console.WriteLine();

            Car car2 = new Car("KIA");
            car2.DisplayInfo();

        }
    }
}