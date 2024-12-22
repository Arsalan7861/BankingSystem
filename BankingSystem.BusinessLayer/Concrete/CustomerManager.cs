using BankingSystem.BusinessLayer.Abstract;
using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerService;

        public CustomerManager(ICustomerDal customerService)
        {
            _customerService = customerService;
        }

        public void TAdd(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void TCreateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc)
        {
            _customerService.CreateCustomer(customerTc, fname, lname, password, phone, address, staffTc);
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TDeleteCustomer(string customerTc)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetAll()
        {
            return _customerService.GetAll();
        }

        public Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer TGetCustomerByTc(string customerTc)
        {
            return _customerService.GetCustomerByTc(customerTc);
        }

        public void TUpdate(Customer entity)
        {
            _customerService.Update(entity);
        }

        public void TUpdateCustomer(string customerTc, string fname, string lname, string password, string phone, string address, string staffTc)
        {
            _customerService.UpdateCustomer(customerTc, fname, lname, password, phone, address, staffTc);
        }
    }
}
