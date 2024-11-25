using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Staff
{
    public int StaffId { get; set; }

    public char StaffFname { get; set; }

    public char StaffLname { get; set; }

    public char StaffPosition { get; set; }

    public char StaffPhonNo { get; set; }

    public char StaffAddress { get; set; }

    public int BranchId { get; set; }

    public int CustomerId { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
