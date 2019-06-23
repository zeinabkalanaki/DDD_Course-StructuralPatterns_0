namespace Pattern03.Strategy.Method_1
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

    public class Order
    {
        public Order(int price, Customer customer)
        {
            Price = price;
            Customer = customer;
        }

        public int Price { get; set; }
        public Customer Customer { get; set; }

        public int GetFinalPrice()
        {
            switch (Customer.CustomerType)
            {
                case CustomerType.Gold:
                    return Price - 20;
                case CustomerType.Silver:
                    return Price - 10;
                case CustomerType.Bronze:
                    return Price - 5;
                default:
                    return Price;
            }
        }

    }
}
