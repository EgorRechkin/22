using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalMathConsole
{
    
    class Program
    {
        static void Main()
        {
            float[] answersY = new float[5] { 6, 6, 1, -1, 11 };
            float[] answersX = new float[5] { 2, 4, 5, 6, 7 };
            float[] x = new float[3] { 15, 10, 5 };
            float[] y = new float[3] { 4, 2, 1 };
            
            float[] x1 = new float[2] { 10, 5 };
            float[] y1 = new float[2] { 2, 1 };
            Console.WriteLine(NewtonForm.MainFunction(1, answersX, answersY));
            
            float[] x2 = new float[4] { 20, 16, 14, 10 };
            float[] y2 = new float[4] { 6, 4, 2, -1 };
            //Console.WriteLine(NewtonForm.findDividedDifference(x2, y2));
            
        }
    }
}
