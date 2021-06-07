using System;

namespace Null_Object_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            var customer = customerService.GetCustomerByFirstName("tosuner");
            Console.WriteLine("FullName : " + customer.GetFullName() + "\nNumber Of Childreen:" + customer.NumberOfChildren);

        }
        public abstract class AbstractCustomer
        {
            public abstract int Id { get; set; }
            public abstract string FirstName { get; set; }
            public abstract string LastName { get; set; }
            public abstract int NumberOfChildren { get; set; }
            public abstract string GetFullName();
        }
        public class Customer : AbstractCustomer
        {
            public override string FirstName { get; set; }
            public override string LastName { get; set; }
            public override int NumberOfChildren { get; set; }
            public override int Id { get; set; }

            public override string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }
        public class NullCustomer : AbstractCustomer
        {
            public override string FirstName { get; set; }
            public override string LastName { get; set; }
            public override int NumberOfChildren { get; set; }
            public override int Id { get; set; }

            public override string GetFullName()
            {
                return "Customer Not Found !";
            }
        }
        public class CustomerService
        {
            public AbstractCustomer GetCustomerByFirstName(string firstName)
            {
                return _customerRepository.Where(c => c.FirstName == firstName).FirstOrDefault().GetValue();
            }
        }
        public static class CustomerExtensions
        {
            public static AbstractCustomer GetValue(this AbstractCustomer customer)
            {
                return customer == null ? new NullCustomer() : customer;
            }
        }
       
    }
}
