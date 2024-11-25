using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Concrete
{
    public class AccountDal : IAccountDal
    {
        readonly BankingDbContext _context = new BankingDbContext();
        public void Add(Account entity)
        {
            _context.Accounts.Add(entity);
        }

        public void Delete(Account entity)
        {
            _context.Accounts.Remove(entity);
        }

        public List<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }

        public Account GetById(int id)
        {
            return _context.Accounts.Find(id);
        }

        public void Update(Account entity)
        {
            _context.Accounts.Update(entity);
        }
    }
}
