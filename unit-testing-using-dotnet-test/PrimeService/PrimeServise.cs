using System;

namespace Lab1
{
    class Equation
    {
         protected double a;
         protected double c;
         protected double x;

        protected  double xmax;
        protected double dx;

        protected double k;


         public virtual void setValue(){

         }
         public virtual void getY(){
             
         }
    }
    class FirstEqu : Equation {
       
        public override void setValue(){
            Console.WriteLine("Input x...");
            string xs = Console.ReadLine();
            x = Convert.ToDouble(xs);
             Console.WriteLine("Input a...");
            xs = Console.ReadLine();
            a =  Convert.ToDouble(xs);
             Console.WriteLine("Input c...");
            xs = Console.ReadLine();
            c =  Convert.ToDouble(xs);

        }
        
        public override void getY() {
            double ft;
            double spt;
            double y;
            ft = Math.Pow((double)this.x * (double)this.c - (double)this.a, 1/3);
            spt = (Math.Log((double)this.x) / (2 * Math.Sin(Math.PI / (3 + this.x))));
            y = ft + spt;
            Console.WriteLine(y);
        }
    }

    class SecEqu : Equation{
       
       
        public override void setValue() {
             Console.WriteLine("Input x...");
            string val = Console.ReadLine();
            x = Convert.ToDouble(val);
             Console.WriteLine("Input a...");
            val = Console.ReadLine();
            a =  Convert.ToDouble(val);
             Console.WriteLine("Input c...");
            val = Console.ReadLine();
            c =  Convert.ToDouble(val);
             Console.WriteLine("Input xmax...");
            val = Console.ReadLine();
            xmax = Convert.ToDouble(val);
             Console.WriteLine("Input dx...");
            val = Console.ReadLine();
            dx = Convert.ToDouble(val);
        }
        public override void getY(){
            double ft;
            double spt;
            double y;
            double xmin = this.x;

            while(xmin < this.xmax) {

                ft = Math.Pow(Math.Pow(xmin, 2) * Math.Pow(this.c, 2) + 2, 1/3);
                spt = (Math.Log(Math.Pow(xmin, 2) + 1) / 2* Math.PI);
                y = ft + spt;
                Console.WriteLine(y);
                xmin += this.dx;
            
            }
        }
    }
    class ThEqu : Equation {
       public override void setValue() {
             Console.WriteLine("Input x...");
            string val = Console.ReadLine();
            x = Convert.ToDouble(val);
             Console.WriteLine("Input a...");
            val = Console.ReadLine();
            a =  Convert.ToDouble(val);
             Console.WriteLine("Input k...");
            val = Console.ReadLine();
            k =  Convert.ToDouble(val);
             Console.WriteLine("Input xmax...");
            val = Console.ReadLine();
            xmax = Convert.ToDouble(val);
             Console.WriteLine("Input dx...");
            val = Console.ReadLine();
            dx = Convert.ToDouble(val);
        }

        public override void getY(){
            double ft;
            double spt;
            double y;
            double xmin = this.x;

            while(xmin < this.xmax) {

                ft = Math.Pow(Math.Cos(this.a * xmin), 1/3);
                spt = (this.k * Math.Cos(this.a * xmin) / Math.Log(this.a * xmin));
                y = ft + spt;
                Console.WriteLine(y);
                xmin += this.dx;
            
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            FirstEqu equ = new FirstEqu();
            equ.setValue();
            equ.getY();
            SecEqu eq = new SecEqu();
            eq.setValue();
            eq.getY();
            ThEqu equa = new ThEqu();
            equa.setValue();
            equa.getY();

        }
    }
}