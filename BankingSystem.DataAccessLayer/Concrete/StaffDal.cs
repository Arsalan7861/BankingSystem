using BankingSystem.DataAccessLayer.Abstract;
using BankingSystem.DataAccessLayer.Repositories;
using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Concrete
{
    public class StaffDal : GenericRepository<Staff>, IStaffDal
    {
        public StaffDal(string connectionString) : base(connectionString)
        {
        }
    }
}
