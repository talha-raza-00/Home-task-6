using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Store
    {
        public string name;
        public string loc;
        private Product[] products;
        private int count;
        public Store(string name,string loc)
        {
            this.name = name;
            this.loc = loc;
            products = new Product[100];
            count = 0;
        }

        public void addproduct(Product p1)
        {
            if(count < products.Length)
            {
                products[count] = p1;
                count++;

            }
            else
            {
                    Console.WriteLine("Limmit is reached !!");
            }
        }

        public void disp()
        {
            Console.WriteLine("INVENTORY");
            for (int i = 0; i < count; i++)
            {
               products [i].disp();

            }



        }
        ~Store()
        {

        }
    }
}
