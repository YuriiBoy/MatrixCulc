using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator.Services
{
    internal class Dialog
    {
        public static double DialogMult()
        {
            double mult = 0;
            Console.WriteLine("\n Please input number to multipal Matrix - ");
            mult = Convert.ToDouble(Console.ReadLine());
            return mult;
        }
    }
}
