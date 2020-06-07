using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            // The "limit" variable contains the maximum value to be displayed for the fibonacci sequence.
            int limit = 350;
            List<int> fibonacciList = new List<int>();

            // Startup => cont, store = 0, preNumber = 1; 
            // Condition => store < limit; 
            // Update => cont = preNumber, preNumber = store, store = cont + preNumber
            for (int cont, store = 0, preNumber = 1; store < limit; cont = preNumber, preNumber = store, store = cont + preNumber)
            {
                fibonacciList.Add(store);
            }

            return fibonacciList;
        }

        public bool IsFibonacci(int numberToTest)
        {
            return Fibonacci().Contains(numberToTest);
        }
    }
}
