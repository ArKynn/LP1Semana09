namespace Polimorfismo;

public class Bat : Animal
{
    public override string Sound()
    {
        return base.Sound() + "Screech";
    }
}