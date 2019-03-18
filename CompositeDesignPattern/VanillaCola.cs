using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    // Leaf classes
    public class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories) : base(calories) { }
    }

    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) { }
    }

    public class StrawberryRootBeer : SoftDrink
    {
        public StrawberryRootBeer(int calories) : base(calories) { }
    }

    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) { }
    }

    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) { }
    }

    //Composite classes
    public class Cola : SoftDrink
    {
        public Cola(int calories) : base(calories) { }
    }

    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }

    // Composite class, root node
    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}
