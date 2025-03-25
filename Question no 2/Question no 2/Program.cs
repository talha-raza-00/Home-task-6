using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape (1,"circle","red");
            Shape s2 = new Shape(2, "square", "yellow");
            Shape orignal = new Shape(3,"triangle","khata");

            // shallow
            Shape shallow = orignal;

            // deep 
            Shape deep = new Shape(orignal);

            // Before changes 
            Console.WriteLine("Shapes before changes !!");
            orignal.disp();

            Console.WriteLine("shallow !!");
            shallow.disp();

            Console.WriteLine("deep !!");
            deep.disp();

            //making changes 
            orignal.ID = 101;
            orignal.Color = "white";
            orignal.Type = "paralelogram";

            // after changes 
            Console.WriteLine("Shapes after changes !!");
            orignal.disp();

            Console.WriteLine("shallow !!");
            shallow.disp();

            Console.WriteLine("deep !!");
            deep.disp();

            // for canvas 
            Canvs c1 = new Canvs(1);
            Canvs orignalcanvas = new Canvs(2);

            // add
            orignalcanvas.addshape(s1);
            orignalcanvas.addshape(s2);    

            Canvs shallowcan= orignalcanvas;
            Canvs deepcan = new Canvs(orignalcanvas);

            //display before changes 
            Console.WriteLine("orignal cannvas !!");
            orignalcanvas.disp();

            //shallow
            Console.WriteLine("shallow cannvas !!");
            shallowcan.disp();

            //deep
            Console.WriteLine("deep cannvas !!");
            deepcan.disp();

            //making chages
            orignalcanvas.ID= 1009;
            orignalcanvas.addshape(orignal);

            //after chages 
            Console.WriteLine("orignal cannvas after changes !!");
            orignalcanvas.disp();

            //shallow
            Console.WriteLine("shallow cannvas after changes !!");
            shallowcan.disp();

            //deep
            Console.WriteLine("deep cannvas after changes !!");
            deepcan.disp();


        }
    }
}
