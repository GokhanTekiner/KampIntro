using System;

namespace Extras2.constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Gökhan", LastName = "Tekiner", City = "Antalya" }; // burada default constructor çalışıyor
            Console.WriteLine(customer1.LastName);

            Customer customer3 = new Customer(); // burada da default constructor çalışıyor
            customer3.Id = 3;
            Console.WriteLine(customer3.Id);


            Customer customer2 = new Customer(2, "Abdül", "Rezzak", "Malatya"); // burada kendi oluşturuduğumuz parametreleri olan constructor çalışıyor


            Console.WriteLine(customer2.FirstName);

        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
