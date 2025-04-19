using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Car
    {
        private string brand;
        private string model;
        private int year;

        public Car(string Brand, string Model, int Year)
        {
            this.brand = Brand;
            this.model = Model;
            this.year = Year;
        }

        public Car(string Brand)
        {
            this.brand = Brand;
            this.model = "Unknown";
            this.year = 0;
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set
            {
                if (value >= 1886)
                {
                    this.year = value;
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
        }

    }
}
