using System;
using System.Collections;
namespace cs
{
    public class Friends
    {
        public ArrayList friends = new ArrayList();


        public void getFriends()
        {
            Console.WriteLine("How many do you have friends?");
            
            int friendsNumber = int.Parse(Console.ReadLine());
            
            
            Console.Write("Please friends names");
            Console.Write("(");
            Console.Write(friendsNumber);
            Console.WriteLine(")");
            
            for (int i = 1; i <= friendsNumber; i++)
            {
                Console.WriteLine("Enter new name:");
                this.friends.Add(Console.ReadLine());
            }
        }
        
        public void checkFriend()
        {
            Console.WriteLine("Enter a name who you want to know if that is your friend:");
            
            string name = Console.ReadLine();
            
            if (this.friends.Contains(name)) 
                Console.WriteLine("Yes. "+ name +" is your friend.");
            else
                Console.WriteLine("No. "+ name +" isn't your friend.");
        }
        

    }
}