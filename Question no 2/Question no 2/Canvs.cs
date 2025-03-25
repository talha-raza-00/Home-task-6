using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Canvs
    {
        private int id;
        private Shape[] shapes;
        private int count;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Canvs(int id)
        {
            this.id = id;
            shapes = new Shape[100];
            this.count =0;
            
        }   

        // for copying 
        public Canvs(Canvs c1)
        {
            id = c1.ID;
            shapes = c1.shapes;
            this.count = c1.count;

            for (int i = 0; i < count; i++)
            {
                this.shapes[i] = c1.shapes[i];
            }
        }

        public void addshape(Shape s1)
        {
            shapes[count] = s1;
            count++;
        }

        public void disp()
        {
            Console.WriteLine("All shapes ");
            for (int i = 0; i < count; i++)
            {
                shapes[i].disp();
            }
        }

       ~ Canvs()
        {

        }

    }
}
