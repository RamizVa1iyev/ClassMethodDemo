using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerManager = new CustomerManager();
            customerManager.Add(new Customer(){Id = 4,FirstName = "Afet",LastName = "Agayeva"});
            customerManager.Update(new Customer(){Id = 4,FirstName = "Afet",LastName = "Valiyeva"});
            customerManager.Delete(new Customer(){Id = 4});
            //customerManager.Clear();
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine("{0} {1} {2}",customer.Id,customer.FirstName,customer.LastName);
            }

            var customers = customerManager.GetByName("VUQar");
            Console.WriteLine("{0} {1} {2}", customers[0].Id, customers[0].FirstName, customers[0].LastName);
        }
    }
}
