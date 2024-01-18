using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator.Models
{
    internal class Matrix
    {
        protected int _rows;
        protected int _cols;
        protected double[][] _arr;

        public Matrix(int rows, int cols, double[][] arr)
        {
            _rows = rows;
            _cols = cols;
            _arr = arr;
        }
        public void Display()
        {
            Console.WriteLine($"\n Matrix of size: {_rows} x {_cols}");
            foreach (var row in _arr) 
            {
                foreach (var item in row)
                {
                    Console.Write($"  {item}");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            double[][] result = new double[m1._rows][];
            for (int i = 0; i < m1._rows; i++)
            {
                result[i] = new double[m1._cols];
                for(int j = 0; j < m1._cols; j++)
                {
                    result[i][j] = m1._arr[i][j] + m2._arr[i][j]; ;
                }
            }
            return new Matrix(m1._rows, m1._cols, result);
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            double[][] res = new double[m1._rows][];
            for(int i = 0;i < m1._rows;i++)
            {
                res[i] = new double[m1._cols];
                for(int j = 0;j < m1._cols;j++)
                    res[i][j] = m1._arr[i][j] - m2._arr[i][j];
            }
            return new Matrix(m1._rows, m1._cols, res);
        }
        public static Matrix operator *(Matrix m1, double mult)
        {
            double[][] res = new double[m1._rows][];
            for(int i =0;i<m1._rows;i++)
            {
                res[i] = new double[m1._cols];
                for(int j = 0; j < m1._cols;j++)
                    res[i][j] = m1._arr[i][j] * mult;
            }
            return new Matrix(m1._rows, m1._cols, res);
        }
    }
}
