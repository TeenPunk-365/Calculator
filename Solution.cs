using System;

namespace Calculator
{
    internal class Solution
    {
        public static double Minus(string k, string a, string b, out string exMessage)
        {
            double a1 = CheckData.CheckDataToDouble(a, out exMessage);
            double b1 = CheckData.CheckDataToDouble(b, out exMessage);

            switch (k) {
                case "+":
                    return a1 + b1;
                case "-":
                    return a1 - b1;
                case "*":
                    return a1 * b1;
                case "/":
                    return a1 / b1;
                default:
                    exMessage = "Invalid value";
                    return 0;
            }
        }
    }
}
