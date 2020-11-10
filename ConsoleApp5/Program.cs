﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Program
    {
        public interface ICalculator
        {
            void Plus(double num);
        }

        public class Calculator : ICalculator
        {
            public double score;
            public void Plus(double num)
            {
                score += num;
            }
            {
                score -= num;
            }
            {
                score *= num;
            }
            {
                if (num == 0)
                {
                    throw new DivideByZeroException();
                }
                score /= num;
            }
            public Calculator()
            {
                score = 0;
            }
        }
        
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Minus(10);
            calc.Plus(20.7);
            Console.WriteLine(calc.score);
        }
    }
}