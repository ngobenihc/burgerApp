using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burgerApp
{
    internal class HangBurger
    {
        private string bname;
        private string bmeat;
        private string rollType;
        private double bprice;

        private string addname1;
        private double addprice1;
        private string addname2;
        private double addprice2;
        private string addname3;
        private double addprice3;
        private string addname4;
        private double addprice4;


        public HangBurger(string bname, string bmeat, string rollType, double bprice)
        {
            this.bname = bname;
            this.bmeat = bmeat;
            this.rollType = rollType;
            this.bprice = bprice;
        }


        public void add1(string name, double price){

            this.addname1 = name;
            this.addprice1 = price;
            }

        public void add2(string name, double price)
        {

            this.addname2 = name;
            this.addprice2 = price;
        }


        public void add3(string name, double price)
        {

            this.addname3 = name;
            this.addprice3 = price;
        }

        public void add4(string name, double price)
        {

            this.addname4 = name;
            this.addprice4 = price;
        }


        public double itemprice()
        {
            double totalPrice =+ this.bprice;

            Console.WriteLine($" burger {bname} and the meat type {bmeat} and roll type is {rollType} and the price is {bprice} ");

            if( addname1 != null)
            {
                totalPrice =totalPrice + addprice1;
                Console.WriteLine($" added {addname1} and the price is {addprice1}");
            }

            if (addname2 != null)
            {
                totalPrice = totalPrice +addprice1;
                Console.WriteLine($" added {this.addname2} and the price is {this.addprice2}");
            }

            if (addname3 != null)
            {
                totalPrice = totalPrice +addprice3;
                Console.WriteLine($" added {this.addname3} and the price is {this.addprice3}");
            }

            if (addname4 != null)
            {
                totalPrice = totalPrice +addprice1;
                Console.WriteLine($" added {this.addname4} and the price is {this.addprice4}");
            }

            return totalPrice;

        }

    }
}
