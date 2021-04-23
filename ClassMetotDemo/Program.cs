using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            {
                customer1.Id = 1;
                customer1.FirstName = "Batu";
                customer1.LastName = "Bayraktar";
                customer1.AccountNumber = 12312412;

            }

            Customer customer2 = new Customer();
            {
                customer2.Id = 2;
                customer2.FirstName = "ece";
                customer2.LastName = "Bayraktar";
                customer2.AccountNumber = 76342342;
            }

            Customer customer3 = new Customer();
            {
                customer3.Id = 3;
                customer3.FirstName = "Emir";
                customer3.LastName = "Bayraktar";
                customer3.AccountNumber = 87654345;
            }


            //Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            //foreach (var customer in customers)
            //{
            //    Console.WriteLine("                        ");
            //    Console.WriteLine("Müşteri No: " +customer.Id);
                
            //    Console.WriteLine("Müşteri Adı: " + customer.FirstName);
            //    Console.WriteLine("Müşteri Soyadı: "+ customer.LastName);
            //    Console.WriteLine("Müşteri Hesap No: " + customer.AccountNumber);
            //}


            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            Console.WriteLine("     ");
            customerManager.RemoveCustomer(customer2);

            

            
        }
    }
}
