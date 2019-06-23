using System;

namespace Pattern04.ChainOfResponsibility
{
    class Program
    {
        public class Customer
        {
            public int AccountValue { get; set; }
            public bool Active { get; set; }
            public int MaxInDateValue { get; set; }
            public string Password { get; set; }
        }

        public class RequestContext
        {
            public string Password { get; set; }
            public int Value { get; set; }
            public Customer CustomerFrom { get; set; }
            public Customer CustomerTo { get; set; }
        }

        public class ResponseContext
        {
            public string ResultMessage { get; set; }
        }

        public abstract class TransferMoney
        {
            protected readonly TransferMoney _successor;
            public TransferMoney(TransferMoney successor)
            {
                _successor = successor;
            }
            public abstract ResponseContext Execute(RequestContext requestContext);
        }

        public class CheckPassword: TransferMoney
        {
            public CheckPassword(TransferMoney successor): base(successor)
            {
            }

            public override ResponseContext Execute(RequestContext requestContext)
            {
                if (requestContext.CustomerFrom.Password == requestContext.Password)
                {
                    return _successor.Execute(requestContext);
                }

                return new ResponseContext() { ResultMessage = "password is wrong"};
            }
        }

        public class CheckMojodi : TransferMoney
        {
            public CheckMojodi(TransferMoney successor) : base(successor)
            {
            }

            public override ResponseContext Execute(RequestContext requestContext)
            {
                if (requestContext.CustomerFrom.AccountValue >= requestContext.Value)
                {
                    return _successor.Execute(requestContext);
                }

                return new ResponseContext() { ResultMessage = "موجودی ناکافی است" };
            }
        }

        public class CheckActive : TransferMoney
        {
            public CheckActive(TransferMoney successor) : base(successor)
            {
            }

            public override ResponseContext Execute(RequestContext requestContext)
            {
                if (requestContext.CustomerFrom.Active == true)
                {
                    return _successor.Execute(requestContext);
                }

                return new ResponseContext() { ResultMessage = "حساب غیر فعال است" };
            }
        }

        public class Transfer : TransferMoney
        {
            public Transfer(TransferMoney successor) : base(successor)
            {
            }

            public override ResponseContext Execute(RequestContext requestContext)
            {
                requestContext.CustomerFrom.AccountValue = requestContext.CustomerFrom.AccountValue - requestContext.Value;
                requestContext.CustomerTo.AccountValue = requestContext.CustomerTo.AccountValue + requestContext.Value;

                return new ResponseContext() { ResultMessage = "انتقال انجام شد" };
            }
        }

        static void Main(string[] args)
        {
            //resolve nested and big if
            //problem is if we want change execute order
            //we have a class with a proccessor function and a property with self type that point to next phaze(reciver/successor)

            //################################
            //Transfer Money
            //################################

            Customer cForm = new Customer()
            {
                AccountValue = 1000,
                Active = true,
                MaxInDateValue = 100,
                Password = "pass"
            };

            Customer cTo = new Customer()
            {
                AccountValue = 10000,
                Active = true,
                MaxInDateValue = 2000,
                Password = "15487"
            };

            //Order execute 1
            var transfer1 = new CheckPassword(new CheckActive(new CheckMojodi(new Transfer(null))));

            var result = 
                transfer1.Execute(new RequestContext()
            {
                CustomerFrom = cForm,
                CustomerTo = cTo,
                Password = "pass",
                Value = 50
            });

            Console.WriteLine(result.ResultMessage);
            

            //Order execute 2
            var transfer2 = new CheckPassword(new CheckMojodi(new CheckActive(new Transfer(null))));

            //Order execute 3
            var transfer3 = new CheckPassword(new CheckActive(new Transfer(null)));

            Console.ReadLine();
        }
    }
}
