using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace cs
{ 
    public class Numbers
    {
        public ArrayList numbers = new ArrayList();
        
        public void oddNumbers()
        {
      		IEnumerable<int> oddNumbers = Enumerable.Range(100, 900).Where(x => x % 2 != 0);
            
            int sum = 0;
            
            foreach (int n in oddNumbers)
                sum = sum + n;

            Console.WriteLine(sum / new List<int>(oddNumbers).Count);
        }
        
        public void evenNumbers()
        {
            float sum = 0;
            
            for (int i = 1; i <= 100; i++)
                if (i % 2 == 0)
                    this.numbers.Add(i);

            foreach (int number in this.numbers)
                sum = sum + number;

            Console.WriteLine(sum);
        }

        public void calculateFactorialTheNumber()
        {
            Console.WriteLine("Enter your number:");

            int num = int.Parse(Console.ReadLine());

            int n = num;

            if (num == 0)
                n = 1;
            
            for (int i = n - 1; i > 0; i--)
                n *= i;

            Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
        }
    }
}