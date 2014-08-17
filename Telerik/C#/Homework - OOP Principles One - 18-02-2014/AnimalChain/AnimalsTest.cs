using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalChain
{
    class AnimalsTest
    {
        static void Main()
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Dog("Doggy", 2, 'M'));
            zoo.Add(new Kitten("Kitty(F)", 8, 'F'));
            zoo.Add(new Tomcat("Kitty(M)", 1, 'M'));
            zoo.Add(new Frog("Froggy", 4, 'M'));
            zoo.Add(new Dog("Doggy2", 7, 'F'));

            foreach (Animal animal in zoo)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            var animalGroups =
                from animal in zoo
                group animal by animal.GetType().Name into groups
                select new { groupName = groups.Key, animals = groups.ToList() };
            foreach (var group in animalGroups)
            {
                Console.WriteLine("Group: {0, 9}s | Average age: {1}", group.groupName.ToString(), GetAverageAge(group.animals));
            }
            Console.WriteLine();
        }
        private static double GetAverageAge(List<Animal> group)
        {
            int age = 0;
            int animals = 0;
            foreach (var animal in group)
            {
                age += animal.Age;
                animals++;
            }
            return (double)age / animals;
        }
    }
}
