using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Branch
{
    public int BranchId { get; set; }

    public char BranchCity { get; set; }

    public char BranchStreet { get; set; }

    public char BranchPostCode { get; set; }

    public char BranchName { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
