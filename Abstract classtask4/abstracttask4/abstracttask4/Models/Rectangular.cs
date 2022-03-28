using System;

namespace abstracttask4.Models
{
    internal class Rectangular : Figure
    {
        private int _Width;
        private int _Length;
    
       

        public int Width
        {
            get
            { return _Width; }
            set
            {
                if (value < 0)


                    System.Console.WriteLine("Menfi ola bilmez");


                { _Width = value; }
            }
        }
        public int Length
        {
            get
            { return _Length; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Menfi ola bilmez");

                { _Length = value; }


            }
        }




        public Rectangular(int width, int length)
        {

            this.Width = width;

            this.Length = length;
        }

        public Rectangular()
        {
        }

        public override void CalcArea()
        {


            Console.WriteLine("Rectangular CalcArea method");
        }
    }
}