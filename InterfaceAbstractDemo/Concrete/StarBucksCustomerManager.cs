using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
     public class StarBucksCustomerManager:BaseCustomerManager 
    {
       private ICustomerCheckService _customerCheckService;

        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);

            }
            else
            {
                throw new Exception("not a valid person");
            }
           
        }

       
    }
}
