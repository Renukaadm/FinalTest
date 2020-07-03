using System;
using System.ComponentModel;

namespace FinalTestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Object[] ObjectsArray = new Object[2];
            ObjectsArray[0] = new Adult("parent1", "parent1");
            ObjectsArray[1] = new Child("Child1","Child1");
            
            foreach (var item in ObjectsArray)
            {
                System.Console.WriteLine(item);
                
            }


        }
    }

    public class Adult
    {
        string FirstName;
        string LastName;
        public Adult(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public override string ToString()
        {
            return this.FirstName+" " + this.LastName;
        }
    }

    public class Child
    {
        string FirstName;
        string LastName;
       public Child(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
   
}
