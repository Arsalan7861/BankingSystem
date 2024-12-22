using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLayer.Abstract
{
    public interface IBranchService : IGenericService<Branch>
    {
        void TCreateBranch(string branchCity, string branchStreet, string branchPostCode, string branchName);
        void TUpdateBranch(int branchId, string branchCity, string branchStreet, string branchPostCode, string branchName);
        void TDeleteBranch(int branchId);
    }
}
