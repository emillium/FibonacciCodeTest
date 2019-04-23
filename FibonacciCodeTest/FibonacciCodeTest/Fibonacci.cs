using System;
using System.Collections.Generic;
using System.Text;

namespace ForTheRecordNet
{
    public abstract class Fibonacci
    {
        private static List<int> _fibs = new List<int> { 0, 1 };

        public static bool IsFib(int number)
        {
            if (_fibs.Contains(number)) // We have already processed this fib number
                return true;
            else if (_fibs.Count > 0 && _fibs[_fibs.Count - 1] > number) // We are sure that the number is not a fib number
                return false;
            else // Calculate the fib number up to the given number
            {
                CalculateFib(number);
                return IsFib(number);
            }
        }

        private static void CalculateFib(int number)
        {
            if (_fibs[_fibs.Count - 1] < number)
            {
                _fibs.Add(_fibs[_fibs.Count - 2] + _fibs[_fibs.Count - 1]);
                CalculateFib(number);
            }
        }
    }
}
