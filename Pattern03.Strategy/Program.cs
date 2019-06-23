using System;

namespace Pattern03.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //replase with switch case or nested if
            //seprate variable logic from fix logic

            //سه نوع مشتری داریم که مقدار تخفیف به آنها متفاوت است
            //خرید لاجیک ثابت
            //تخفیف لاجیک متغییر است
            //اگر قسمت متغییر عوض شد چه کنیم؟

            //Method 1
            //add another enum and ... do not pass "O"
            Method_1.Customer customer1 = new Method_1.Customer()
            {
                FirstName = "FirstName",
                LastName = "LastName",
                CustomerType = Method_1.CustomerType.Gold
            };

            Method_1.Order order1 = new Method_1.Order(1000, customer1);
            Console.WriteLine(order1.GetFinalPrice());

            //Method 2 
            //add abstract calss variable logic part ... do pass "O"
            //Method_2.Customer customer2 = new Method_2.Customer()
            //{
            //    FirstName = "FirstName",
            //    LastName = "LastName",
            //    CustomerType = Method_2.CustomerType.Gold
            //};

            Method_2.CalcFinalPrice calcFinalPrice_gold = new Method_2.GoldCalculator();
            //Method_2.CalcFinalPrice calcFinalPrice_null = new Method_2.NullCalculator();

            Method_2.Order order2 = new Method_2.Order(1000, calcFinalPrice_gold);
            Console.WriteLine(order2.GetFinalPrice());

            Console.WriteLine("Hello World!");
        }
    }
}
