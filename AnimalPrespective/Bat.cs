namespace Polimorfismo;

public class Bat : Animal, IMammal
{
    public override string Sound()
    {
        return base.Sound() + "Screech";
    }

    public int NumberOfNipples { get; } = 2;
}