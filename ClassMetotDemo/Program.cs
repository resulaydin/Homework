namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer() {Id=32,FirtName="Guest",LastName="Guests",City="Ankara" };
            Customer customer2 = new Customer() {Id=11};

           
            customerManager.Add(customer1);
            Console.WriteLine("Customer Guest is Listed ");
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.Id+" - "+customer.FirtName+" - "+ customer.LastName+" - "+customer.City);
            }

            customerManager.Update(customer1);
            Console.WriteLine("Customer Guest is Updated to Tenacious: ");
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.Id + " - " + customer.FirtName + " - " + customer.LastName + " - " + customer.City);
            }

            customerManager.Delete(customer2);
            Console.WriteLine("Customer(customer2) Id=11 is Deleted: ");
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.Id + " - " + customer.FirtName + " - " + customer.LastName + " - " + customer.City);
            }
        }
    }
}