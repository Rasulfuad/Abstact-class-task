using System;

namespace abstracttask4.Models
{
    internal class Square : Figure
    {
        private int _Side;
        public int Side
        {
            get
            { return _Side; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Menfi ola bilmez");


                { _Side = value; }
            }
        }
        

        public Square(int side)
        {
            Side = side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Square CalcArea method");
        }

    }
}