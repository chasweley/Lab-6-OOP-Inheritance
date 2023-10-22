namespace Lab6OOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(); //Creating new objects for each class
            Cat cat = new Cat();
            Dog dog = new Dog();
            AustralianShepherd australianShepherd = new AustralianShepherd();
            Dachshund dachshund = new Dachshund();

            //For each object in the different classes printing out all the different methods

            bird.makeSound();
            bird.CanBirdFly();
            bird.Sleeping();

            Console.WriteLine();

            cat.makeSound();
            cat.IsPurring();
            cat.LikeToEat();

            Console.WriteLine();

            dog.makeSound();
            dog.IsWaggingTail();

            Console.WriteLine();

            australianShepherd.makeSound();
            australianShepherd.Agility();

            Console.WriteLine();

            dachshund.makeSound();
            dachshund.IsDiggingWell();
        }
    }
}