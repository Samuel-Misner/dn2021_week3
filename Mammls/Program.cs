using System;

namespace Mammals
{
    class Mammal
    {
        public string TypeOfHair;
        public int NumberOfTeeth;

        public Mammal(string typeOfHair, int numberOfTeeth)
        {
            TypeOfHair = typeOfHair;
            NumberOfTeeth = numberOfTeeth;
        }
    }

    class Cat : Mammal
    {
        public int RetractClawsCount;
        public Cat(int countClaws, string toHair, int noTeeth) : base(toHair, noTeeth)
        {
            RetractClawsCount = countClaws;
        }
    }

    class Dog : Mammal
    {
        public int NumberOfTricks;
        public bool IsDomesticated;
        public Dog() : base("none selected", 32)
        {
            NumberOfTricks = 0;
            IsDomesticated = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog Nellie = new Dog();
            Nellie.NumberOfTricks = 3;
            Nellie.IsDomesticated = true;
            Nellie.TypeOfHair = "Soft and Long";
            Nellie.NumberOfTeeth = 20;

            Cat DonaldDuck = new Cat(0, "Soft and Short", 18);

            Cat MickeyMouse = new Cat(16, "Soft and Longhaired", 18);
        }
    }
}
