using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
        void CreateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc);

        void UpdateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc);

        void DeleteCustomer(string customerTc);
        Customer GetCustomerByTc(string customerTc);
        List<Customer> SearchCustomer(string customerTc);
    }
}
