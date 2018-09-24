using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSaveToGitHubLater
{
    class Program 
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Name the type of animal, EG dog");
            string animalType = Console.ReadLine();
            Console.WriteLine("What type of sound does your animal make");
            string animalSound = Console.ReadLine();

            Animal first = new Animal(animalType, animalSound);

            Console.WriteLine(first.AnimalSays());
            Console.ReadLine();
        }    
    }
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal(string _name, string _sound) //Constructor List 
        {
            Name = _name;
            Sound = _sound;
        }
        public string AnimalSays()
        {
            return $"Your {Name} says {Sound}";
        }
    }
}
