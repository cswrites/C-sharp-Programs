using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("the animal makes sound.");
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("The dog barks");
        }
    public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The cat meows.");
            }
        }
        class Program
        {
            static void Main()
            {
                Animal animal = new Animal();  //instances of Animal, Dog, and Cat 
                Dog dog = new Dog();
                Cat cat = new Cat();

                Console.WriteLine("Animal Sound");
                animal.MakeSound();

                Console.WriteLine("Dog sounds: ");
                dog.MakeSound();

                Console.WriteLine("Cat sounds: ");
                cat.MakeSound();
            }
        }

    }
}