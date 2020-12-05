using System;
using System.Collections;
namespace cs
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public ArrayList scores = new ArrayList();


        public void setName()
        {
            Console.WriteLine("Enter first name:");

            this.firstName = Console.ReadLine();
            
            Console.WriteLine("Enter last name:");

            this.lastName = Console.ReadLine();
        }

        public void setScores()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter score ");
                Console.Write(i);
                Console.Write(":");
                this.scores.Add(float.Parse(Console.ReadLine()));
            }
        }
        
        public void showAvg()
        {
            float sum = 0;
            
            foreach (float i in this.scores)
            {
                sum = sum + i;
            }
            
            Console.Write(this.firstName);
            Console.Write(" ");
            Console.Write(this.lastName);
            Console.Write("'s avrage is:");
            Console.WriteLine(sum / this.scores.Count);
        }
    }
}