using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern02.Decorator.Method_1
{
    public abstract class Icecream
    {
        public abstract int GetPrice();
    }

    public class LargeOne : Icecream
    {
        public override int GetPrice()
        {
            return 200;
        }
    }

    public class MediumOne : Icecream
    {
        public override int GetPrice()
        {
            return 150;
        }
    }

    public class SmallOne : Icecream
    {
        public override int GetPrice()
        {
            return 100;
        }
    }
}
