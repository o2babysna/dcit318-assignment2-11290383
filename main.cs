 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance & Method Overriding ===");
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.WriteLine("\n=== Abstract Classes & Methods ===");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

            Console.WriteLine("\n=== Interfaces ===");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
