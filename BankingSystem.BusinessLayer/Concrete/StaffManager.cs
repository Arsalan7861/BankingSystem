﻿using BankingSystem.BusinessLayer.Abstract;
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

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Staff> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Staff TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Staff entity)
        {
            throw new NotImplementedException();
        }
    }
}
