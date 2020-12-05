using System;
using System.Collections;
namespace cs
{ 
    public class Numbers
    {
        public ArrayList numbers = new ArrayList();
        
        public void oddNumbers()
        {
            float sum = 0;
            
            for (int i = 100; i < 1000; i++)
                if (i % 2 != 0)
                    this.numbers.Add(i);
            
            foreach (int number in this.numbers)
                sum = sum + number;

            Console.WriteLine(sum / this.numbers.Count);
        }
    }
}