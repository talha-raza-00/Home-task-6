using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101,"BMW");
            Product p3 = new Product(109,"laptop",10.5m);
            Product p4 = new Product(104,"Gpu",150m,10);

            Store s1 = new Store("Talha's store", "DUBAI"); 
            s1.addproduct(p1);
            s1.addproduct(p2);
            s1.addproduct(p3);
            s1.addproduct(p4);

            s1.disp();

        }
    }
}
