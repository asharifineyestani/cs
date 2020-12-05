using System;
using System.Collections;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.showAverageExample();

        }
        
        
        public void showAverageExample()
        {
            Student student = new Student();
            
            student.setName();

            student.setScores();
            
            student.showAvg();
            
        }
    }
}
