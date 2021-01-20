using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, FirstName = " Gökhan ", LastName = "Tekiner ", City = "Antalya" };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Delete(customer);

        }
                
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }   
        
    }

    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.FirstName + customer.LastName + customer.City);
            Console.WriteLine("Müşteri eklendi!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id + customer.FirstName + customer.LastName + customer.City);
            Console.WriteLine("Müşteri Silindi!");
        }
    }

    
}
