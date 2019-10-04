using Acme.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.DAL
{
    public class Repository
    {
        private List<Customer> _customers = new List<Customer>();
        public void Save(Customer customer)
        {
            _customers.Add(customer);
        }

        public int NumberOfCustomers()
        {
            return _customers.Count;
        }
    }
}
