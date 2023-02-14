using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        List<Customer> _customerList;
        public CustomerManager()
        {
            _customerList = new List<Customer>
            {
                new Customer(){Id=11,FirtName="İnsan",LastName="İnsans",City="Evren" },
                new Customer(){Id=12,FirtName="Adem",LastName="Adems",City="Dünya" },
                new Customer(){Id=13,FirtName="Human",LastName="Humans",City="Dünya" },
            };
        }
        public void Add(Customer customer)
        {
            _customerList.Add(customer);
        }
        public void Delete(Customer customer)
        {
            var queryCustomer = (from singlecustomer in _customerList
                                 where singlecustomer.Id == customer.Id
                                 select singlecustomer).ToList();
            _customerList.Remove(queryCustomer[0]);

            // Veya aşağıdaki gibi kullanılabilir
            //foreach (var singleCustomer in _customerList.Where(p => p.Id == customer.Id).ToList())
            //{
            //    _customerList.Remove(singleCustomer);
            //}
        }
        public void Update(Customer customer)
        {

            foreach (var singleCustomer in _customerList.Where(p => p.Id == customer.Id).ToList())
            {
                singleCustomer.FirtName= "Tenacious";
                singleCustomer.City= "Ankara";
            }
        }
        public List<Customer> GetAll()
        {
            return _customerList;
        }
    }
}
