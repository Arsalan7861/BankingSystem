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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void TAdd(Staff entity)
        {
            throw new NotImplementedException();
        }

        public void TCreateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email)
        {
            _staffDal.CreateStaff(staffTc, fname, lname, password, position, phone, branchId, address, email);
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TDeleteStaff(string staffTc)
        {
            _staffDal.DeleteStaff(staffTc);
        }

        public List<Staff> TGetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public Staff TGetManagerByTc(string managerTc)
        {
            return _staffDal.GetManagerByTc(managerTc);
        }

        public void TUpdate(Staff entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdateStaff(string staffTc, string fname, string lname, string password, string position, string phone, int branchId, string address, string email)
        {
            _staffDal.UpdateStaff(staffTc, fname, lname, password, position, phone, branchId, address, email);
        }
    }
}
