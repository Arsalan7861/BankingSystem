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
        void createBranch(string branchCity, string branchStreet, string branchPostCode, string branchName);
        void updateBranch(int branchId, string branchCity, string branchStreet, string branchPostCode, string branchName);
        void deleteBranch(int branchId);
    }
}
