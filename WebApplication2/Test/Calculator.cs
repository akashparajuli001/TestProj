using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Test
{
    public class Calculator : ICalculator
    {

        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Mul(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
    }
}