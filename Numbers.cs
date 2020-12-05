using System;
using System.Collections;
namespace cs
{
    public class Numbers
    {
        public ArrayList numbers = new ArrayList();
        
        public void oddNumbers()
        {
            for (int i = 100; i < 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i.ToString());
                    Console.Write(',');
                }
            }
        }
        
    }
}