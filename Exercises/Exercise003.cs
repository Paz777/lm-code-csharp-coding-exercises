using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = new string[]
            { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string iceCreamFlavour)
            => Array.IndexOf(IceCreamFlavours, iceCreamFlavour);
    }
}
