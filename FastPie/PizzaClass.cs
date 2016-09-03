using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPie
{
    class PizzaClass
    {
        int cnt;

        string size,
               crust,
               meat,
               veggie;

        double price;

        public PizzaClass()
        { }

        public PizzaClass(int pizzaNumber)
        {
            cnt = pizzaNumber;
        }

        public PizzaClass(string pizzaSize, string PizzaCrust, 
                            string PizzaMeat, string PizzaVeggie)
        {
            size = pizzaSize;
            crust = PizzaCrust;
            meat = PizzaMeat;
            veggie = PizzaVeggie;
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Crust
        {
            get { return crust; }
            set { crust = value; }
        }

        public string Meat 
        {
            get { return meat; }
            set { meat = value; }
        }

        public string Veggie
        {
            get { return veggie; }
            set { veggie = value; }
        }

        public int Cnt
        {
            get { return cnt; }
            set { cnt = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public override string ToString()
        {
            return string.Format("{0} :{1:C} : {2}, {3}, {4} {5}\n", 
                                    cnt ,price, size, crust, meat, veggie);
        }
    }
}
