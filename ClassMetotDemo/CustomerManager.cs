using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        string AddCustomerSuccessfull = "Müşteri Sisteme Başarıyla Eklendi";
        string AddCustomerTemplate = "Müşteri Bilgileri";

        public void AddCustomer(Customer customer)
        {
            
            Console.WriteLine(AddCustomerTemplate);
            Console.WriteLine("             ");
            Console.WriteLine("Id: " + customer.Id);
            Console.WriteLine("İsim: " + customer.FirstName);
            Console.WriteLine("Soyad: " + customer.LastName);
            Console.WriteLine("Hesap No: " + customer.AccountNumber);
            Console.WriteLine("             ");
            Console.WriteLine(AddCustomerSuccessfull);
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Sistemden Silindi");
            Console.WriteLine("Müşteri No: " + customer.Id);
        }

    }
}
