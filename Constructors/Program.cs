using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { ID = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.ID = 3;

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
