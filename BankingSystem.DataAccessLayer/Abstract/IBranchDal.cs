using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Abstract
{
    public interface IBranchDal : IGenericDal<Branch>
    {
        void CreateBranch(string branchCity, string branchStreet, string branchPostCode, string branchName);
        void UpdateBranch(int branchId, string branchCity, string branchStreet, string branchPostCode, string branchName);
        void DeleteBranch(int branchId);
    }
}
