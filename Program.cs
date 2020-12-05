using System;
using System.Collections;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.showFriendExample();

        }
        
        
        public void showAverageExample()
        {
            Student student = new Student();
            
            student.setName();

            student.setScores();
            
            student.showAvg();
            
        }
        
        public void showFriendExample()
        {
            Friends friends = new Friends();
            
            friends.getFriends();
            friends.checkFriend();

           
        }
    }
}
