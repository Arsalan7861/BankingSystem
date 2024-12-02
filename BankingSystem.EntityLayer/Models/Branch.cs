using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Branch
{
    public int Branchid { get; set; }

    public string Branchcity { get; set; } = null!;

    public string Branchstreet { get; set; } = null!;

    public string Branchpostcode { get; set; } = null!;

    public string Branchname { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
