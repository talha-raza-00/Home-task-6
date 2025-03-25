using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int quantity;

        // 2nd Approch 
        public void checkquant(int quant)
        {
            if (quant >= 0 && quant <= 100)
            {
                this.quantity = quant;
            }
            else
            {
                Console.WriteLine("Out of range (1-100) !!");
                this.quantity = 0;
            }
        }
        public Product(int id = 0, string name = " ", decimal price = 0, int quant = 0)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            checkquant(quant);
        }


        // 4th Approch
        //public Product(int id = 0, string name = " ", decimal price = 0, int quant = 0)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.price = price;
        //    if (quant >= 0 && quant <= 100)
        //    {
        //        this.quantity = quant;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Out of range (1-100) !!");
        //        this.quantity = 0;
        //    }
        //}

        // 3rd Approch
        public Product(int id, string name, decimal price):this(id,name,price,0)
        {

        }
        public Product(int id, int quant) : this(id, " ", 0, quant)
        {

        }
        public Product(int id, string name) : this(id, name,0,0)
        {

        }

        public void disp()
        {
            Console.WriteLine($"ID = {id} \n Name = {name} \n Price = {price} \n Quantity = {quantity}");
        }

        ~Product()
        {
            Console.WriteLine($"Product having id  {id} is killed !! ");
        }
    }
}
