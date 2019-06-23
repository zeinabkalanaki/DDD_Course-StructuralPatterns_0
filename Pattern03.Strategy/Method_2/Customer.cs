using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern03.Strategy.Method_2
{
    public enum CustomerType
    {
        Gold,
        Silver,
        Bronze
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType CustomerType { get; set; }
    }

    public abstract class CalcFinalPrice
    {
        public abstract int Calculate(int price);
    }

    public class GoldCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - 20;
        }
    }

    public class SilverCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - 10;
        }
    }

    public class BronzeCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return price - 5;
        }
    }

    public class NullCalculator : CalcFinalPrice
    {
        public override int Calculate(int price)
        {
            return price;
        }
    }

    public class Order
    {
        public Order(int price, CalcFinalPrice calcFinalPrice)
        {
            Price = price;
            CalcFinalPrice = calcFinalPrice;
        }

        public int Price { get; set; }
        public CalcFinalPrice CalcFinalPrice { get; set; }

        public int GetFinalPrice()
        {
            return CalcFinalPrice.Calculate(Price);
        }

    }
}
