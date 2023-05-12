namespace Polimorfismo;

public class Bee : Animal, ICanFly
{
    public override string Sound()
    {
        return base.Sound() + "Buzzz";
    }

    public int NumberOfWings { get; } = 4;
}