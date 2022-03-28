using abstracttask4.Models;
using System;

namespace abstracttask4

{
    internal class Program
    {

        static void Main(string[] args)
        {

            int num1 = Convert.ToInt32(Console.ReadLine());

            Figure[] figures = new Figure[1];
            for (int i = 0; i < figures.Length; i++)
            {
                switch (num1)
                {

                    case 0:
                        {
                            Console.ReadKey();
                        }
                        break;
                    case 1:
                        {
                            Square num2 = new Square();
                            num2.CalcArea();
                        }
                        break;
                    case 2:
                        {
                            Rectangular num2 = new Rectangular();
                            num2.CalcArea();

                        }
                        break;



                }




            }



        }
    }
}




