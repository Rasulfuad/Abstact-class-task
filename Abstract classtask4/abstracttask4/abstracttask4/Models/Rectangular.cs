using System;

namespace abstracttask4.Models
{
    internal class Rectangular : Figure
    {
        private int _Width;
        private int _Length;
        private int v1;
        private object width;
        private int v2;
        private object length;

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

        public override void CalcArea()
        {


            Console.WriteLine("Rectangular CalcArea method");
        }
    }
}