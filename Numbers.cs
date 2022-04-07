using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        private int _b, _e;

        // menggunakan static method
        public static int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2; //menggunakan operator ternary agar lebih praktis
        }

        // menggunakan overloading method
        public int FindMinimum(int number1, int number2, float number3)
        {
            _b = number1 < number3 ? number1 : (int)number3;
            _e = number2 < number3 ? number2 : (int)number3;
            return number1 < number2 ? _b : _e;
        }

        // menggunakan static method
        public static int FindMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }

        // menggunakan overloading method
        public int FindMaximum(int number1, int number2,float number3)
        {
            _b = number1 > number3 ? number1 : (int)number3;
            _e = number2 > number3 ? number2 : (int)number3;
            return number1 > number2 ? _b : _e;
        }
    }
}
