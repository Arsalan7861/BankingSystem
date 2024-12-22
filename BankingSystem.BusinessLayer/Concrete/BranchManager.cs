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
    public class BranchManager : IBranchService
    {
        private readonly IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public void TAdd(Branch entity)
        {
            throw new NotImplementedException();
        }

        public void TcreateBranch(string branchCity, string branchStreet, string branchPostCode, string branchName)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TdeleteBranch(int branchId)
        {
            throw new NotImplementedException();
        }

        public List<Branch> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Branch TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Branch entity)
        {
            throw new NotImplementedException();
        }

        public void TupdateBranch(int branchId, string branchCity, string branchStreet, string branchPostCode, string branchName)
        {
            throw new NotImplementedException();
        }
    }
}
