using System;
using System.Collections.Generic;

namespace AnimalsDemo
{
    class Animal
    {
        public int NumberOfCells;
        public Animal()
        {
            NumberOfCells = 0;
        }
        public Animal(int NumberOfCells)
        {
            this.NumberOfCells = NumberOfCells;
        }

        public override string ToString()
        {
            return $"This animal has {NumberOfCells} cells.";
        }

        public List<Animal> Animals = new List<Animal>();
    }

    class Bird : Animal
    {
        public int LengthOfBeak;
        public Bird()
        {
            LengthOfBeak = 1;
        }
        public Bird(int LengthOfBeak, int NumberOfCells) : base(NumberOfCells)
        {
            this.LengthOfBeak = LengthOfBeak;
        }

        public override string ToString()
        {
            return $"This bird has {NumberOfCells} cells and its beak is {LengthOfBeak} inches long";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal.Animals.Add(new Animal(1000));

            Animal.Animals.Add(new Animal(5000));

            Animal.Animals.Add(new Bird(20, 10000));

            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
