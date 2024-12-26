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

        public void TCreateBranch(string branchCity, string branchStreet, string branchPostCode, string branchName)
        {
            _branchDal.CreateBranch(branchCity, branchStreet, branchPostCode, branchName);
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBranch(int branchId)
        {
            _branchDal.DeleteBranch(branchId);
        }

        public List<Branch> TGetAll()
        {
            return _branchDal.GetAll();
        }

        public Branch TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Branch> TSearchBranch(string branchName)
        {
            return _branchDal.SearchBranch(branchName);
        }

        public void TUpdate(Branch entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBranch(int branchId, string branchCity, string branchStreet, string branchPostCode, string branchName)
        {
            _branchDal.UpdateBranch(branchId, branchCity, branchStreet, branchPostCode, branchName);
        }
    }
}
