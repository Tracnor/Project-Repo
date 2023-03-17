using System;
using rer;

class Program
{
    static void Main(string[] args)
    {
        Character Character = new Character();
        Console.WriteLine("Enter your character's character name: ");
        Character.Name = Console.ReadLine();
        Console.WriteLine("Your character's name is:" + Character.Name);


        while (true)
        {
            Console.WriteLine("Choose your character's class:");
            Console.WriteLine("1: Engineer");
            Console.WriteLine("2: Scientist");
            Console.WriteLine("3: Soldier");
            Console.WriteLine("4: Medic");
            int characterClass = Convert.ToInt16(Console.ReadLine());

            switch (characterClass)
            {
                case 1:
                    Character.Specialty = "Engineer";
                    break;
                case 2:
                    Character.Specialty = "Scientist";
                    break;
                case 3:
                    Character.Specialty = "Soldier";
                    break;
                case 4:
                    Character.Specialty = "Medic";
                    break;
                default:
                    Console.WriteLine("U fookin wot m8?");
                    break;
            }
            Console.WriteLine("Your character's specialty is: " + Character.Specialty);
            break;
        }
        Environment.Exit(0);
    }

}
