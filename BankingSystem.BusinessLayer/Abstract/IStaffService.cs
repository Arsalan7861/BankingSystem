using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        void TCreateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email);
        void TUpdateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email);
        void TDeleteStaff(string staffTc);
        Staff TGetManagerByTc(string managerTc);
    }
}
