using System;

namespace FirstConsoleProject
{
    // Here we will build our Classes
    class Character
    {
        // You must initialize variables in a class.
        public string name;

        // This is a class constructor. They are special methods that automatically run when an object of a class is created. Useful for setting initial values.
        public Character(string charName)
        {
            name = charName;
        }
    }


    // This class will hold our MAIN program. No other classes will go in here.
    class Program
    {

        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, welcome to our Game!.\n");
            Console.WriteLine("Enter the name of your character:");
            // This is asking for your characters name and setting it equal to the variable called name
            string name = Console.ReadLine();

            // I am instantiating the object "firstChar" using the Character class above and passing it the name variable.
            Character firstChar = new Character(name);

            // I am accessing the "property" of the object firstChar called "name". 
            Console.Write(firstChar.name);
           
        }
    }
}
