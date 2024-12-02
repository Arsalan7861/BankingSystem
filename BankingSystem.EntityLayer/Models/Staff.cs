using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Staff
{
    public string Stafftc { get; set; } = null!;

    public string Stafffname { get; set; } = null!;

    public string Stafflname { get; set; } = null!;

    public string Staffposition { get; set; } = null!;

    public string Staffphone { get; set; } = null!;

    public int Branchid { get; set; }

    public string Staffaddress { get; set; } = null!;

    public string Customertc { get; set; } = null!;

    public string Staffemail { get; set; } = null!;

    public virtual Branch Branch { get; set; } = null!;

    public virtual Customer CustomertcNavigation { get; set; } = null!;

    public virtual ICollection<Log> Log { get; set; } = new List<Log>();
}
