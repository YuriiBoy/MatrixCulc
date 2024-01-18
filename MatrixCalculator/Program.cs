using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixCalculator.Models;
using MatrixCalculator.Services;


namespace MatrixCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // 1 Matrix test1
            const int rows = 3;
            const int cols = 3;
            var a = new double[rows][];

            a[0] = new double[cols] { 10, 20, 30 };
            a[1] = new double[cols] { 40, 50, 60 };
            a[2] = new double[cols] { 70, 80, 90 };
            
            var m1 = new Matrix(rows, cols, a);
            m1.Display();
            Console.WriteLine("+");

            var b = new double[rows][];

            b[0] = new double[cols] { 100, 200, 300 };
            b[1] = new double[cols] { 400, 500, 600 };
            b[2] = new double[cols] { 700, 800, 900 };
            
            var m2 = new Matrix(rows, cols, b);
            m2.Display();
            Console.WriteLine("=");

            // 
            Matrix m3 = m1 + m2;
            m3.Display();

            //
            Matrix m4 = m1 - m2;
            m4.Display();

            //
            double mult = Dialog.DialogMult();
            Matrix m5 = m1 * mult;
            m5.Display();

           
            // Fin
            Console.WriteLine("\n Finish");

        }
    }
}
