using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern02.Decorator.Method_2
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

    public class IcecreamDecorator : Icecream
    {
        private readonly Icecream _icecream;
        public IcecreamDecorator(Icecream icecream)
        {
            _icecream = icecream;
        }

        public override int GetPrice()
        {
            return _icecream.GetPrice();
        }
    }

    public class IcecreamWithSmartis : IcecreamDecorator
    {
        public IcecreamWithSmartis(Icecream icecream) : base(icecream)
        {
        }

        public override int GetPrice()
        {
            return base.GetPrice() * 20;
        }
    }

    public class IcecreamWithChocolate : IcecreamDecorator
    {
        public IcecreamWithChocolate(Icecream icecream) : base(icecream)
        {
        }

        public override int GetPrice()
        {
            return base.GetPrice() * 30;
        }
    }

}
