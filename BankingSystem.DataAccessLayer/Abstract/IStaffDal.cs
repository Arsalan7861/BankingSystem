using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Abstract
{
    public interface IStaffDal : IGenericDal<Staff>
    {
        void CreateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email);
        void UpdateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email);
        void DeleteStaff(string staffTc);
    }
}
