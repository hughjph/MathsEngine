using System;
using System.Collections;
using System.Collections.Generic;

namespace MathsEngine
{
    public class Differentiation
    {
        private IDictionary methods = new Dictionary<int, string>()
        {
            { 0, "simple" },
            { 1, "chain rule" },
            { 2, "product rule" },
            { 3, "quotient rule" }
        };
        
        public static string Differentiate(string equation)
        {
            Console.WriteLine("Maths init");
            int method = GetMethod(equation);

            string solution;
            
            switch (method)
            {
                case 0:
                    solution = SimpleDifferentiation(equation);
                    break;
                case 3:
                    solution = QuotientRuleDifferentiation(equation);
                    break;
                case 5:
                    solution = "Error: Could not find a way of differentiation.";
                    break;
                default:
                    solution = "n/a";
                    break;
            };

            return solution;
        }

        static int GetMethod(string equation)
        {
            
            
            if (equation.Contains('/'))
            {
                string denominator = equation.Substring(equation.IndexOf('/'));

                if (denominator.Contains('+'))
                {
                    return 3;
                }
            }
            
            
            return 4;
        }

        static string SimpleDifferentiation(string equation)
        {
            return "differentiated equation";
        }

        static string ChainRuleDifferentiation(string equation)
        {
            return "chain rule equation";
        }

        static string ProductRuleDifferentiation(string equation)
        {
            return "product rule equation";
        }

        static string QuotientRuleDifferentiation(string equation)
        {
            return "quotient rule equation";
        }
    }
}