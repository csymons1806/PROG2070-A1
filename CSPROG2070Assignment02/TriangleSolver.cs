using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A02CS
{
    public static class TriangleSolver
    {

        public static string Analyze(int num1, int num2, int num3)
        {

            string message = "";

            if (num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1)
            {
                return "Invalid";
            }
            else
            {
                message += $"Valid\n";
            }

            if (num1 == num2 && num2 == num3 && num1 == num3)
            {
                message += "Equilateral";
            }
            else if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                message += "Isosceles";
            }
            else
            {
                message += "Scalene";
            }

            return message;

        }

    }
}
