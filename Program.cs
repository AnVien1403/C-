// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
    class Rectangular
    {
        //attrinute
        double Length;
        double Width;
        //action
        public Rectangular init(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
            return this;
        }

        public double Area()
        {
            return Length * Width;
        }

        public void Show(){
            Console.WriteLine("Chieu dai : "+Length);
            Console.WriteLine("Chieu rong : "+Width);
            Console.WriteLine("Area : "+Length*Width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangular rec = new Rectangular();
            // rec = rec.init(8.1 , 5.3);
            // rec.Show();
            //tham tri/doi tuong/con tro
            //tham tri : boolean
            // Console.WriteLine("Size of Bool : "+sizeof(bool));
            // //byte 0-255(2^8=256)
            // Console.WriteLine("Size of Byte : "+sizeof(byte));
            // //char,decimal,float,double,int,long,
            // Console.WriteLine("Size of char : "+sizeof(char));
            // Console.WriteLine("Size of decimal : "+sizeof(decimal));
            // Console.WriteLine("Size of float : "+sizeof(float));
            // Console.WriteLine("Size of double : "+sizeof(double));
            // Console.WriteLine("Size of int : "+sizeof(int));
            // Console.WriteLine("Size of long : "+sizeof(long));

            //doi tuong-tham chieu
            object obj;
            obj=20;//boxing-unboxing;
            dynamic d=1;
            d="String";
            d=1.1;
            d=new Rectangular();
            String str= "Hello \"John Doe\"";
            Console.WriteLine(str);
            //con tro
            
            //ep kieu
            

        }
    }
}


