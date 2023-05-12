using System;

namespace Polimorfismo
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }

        public int NumberOfNipples { get; } = 8;
    }
}
