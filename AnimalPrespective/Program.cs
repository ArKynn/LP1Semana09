using Polimorfismo;

namespace AnimalPrespective;

public class Program
{
    public static void Main()
    {
        Animal[] animals = new Animal[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            animals[i] = random.Next(4) switch
            {
                0 => new Bat(),
                1 => new Bee(),
                2 => new Cat(),
                3 => new Dog(),
                _ => throw new ArgumentOutOfRangeException("Unknown animal!")
            };
        }


        foreach (Animal animal in animals)
        {
            Console.WriteLine($"{animal.Sound()}");
            if (animal is IMammal)
            {
                Console.WriteLine($"Nº of Nipples: {(animal as IMammal)!.NumberOfNipples}"); 
            }

            if (animal is ICanFly)
            {
                Console.WriteLine($"Nº of Wings: {(animal as ICanFly)!.NumberOfWings}");
            }
        }
    }
}