using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class InsuranceContext
    {
        private List<Customer> customerList;
        public List<Customer> createCustomers()
        {
            customerList = new List<Customer>();
            customerList.Add(new Customer { Name = "Arun", DOB = new DateTime(1978, 1, 1), Address = "Chennai", MobileNo = "9897523454" });
            customerList.Add(new Customer { Name = "Swapna", DOB = new DateTime(1989, 7, 15), Address = "Bangalore", MobileNo = "9997523454" });
            customerList.Add(new Customer { Name = "John", DOB = new DateTime(1994, 8, 12), Address = "Chennai", MobileNo = "8897523454" });
            customerList.Add(new Customer { Name = "Shyam", DOB = new DateTime(1991, 3, 1), Address = "Delhi", MobileNo = "9997526754" });
            customerList.Add(new Customer { Name = "Rhama", DOB = new DateTime(1970, 12, 2), Address = "Pune", MobileNo = "7897523454" });
            customerList.Add(new Customer { Name = "Geetha", DOB = new DateTime(1978, 7, 7), Address = "Bangalore", MobileNo = "9997223454" });
            return customerList;
        }

        public List<Customer> getCustomerByIndex(String value)
        {
            List<Customer> filteredCustomerList = new List<Customer>();
            foreach(Customer customer in createCustomers())
            {
                if(customer.MobileNo.StartsWith(value))
                {
                    filteredCustomerList.Add(customer);

                }
            }
            return filteredCustomerList;

        }
    }
}
