namespace Polimorfismo;

public class Bat : Animal, IMammal, ICanFly
{
    public override string Sound()
    {
        return base.Sound() + "Screech";
    }

    public int NumberOfNipples { get; } = 2;
    public int NumberOfWings { get; } = 2;
}