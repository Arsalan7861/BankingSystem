using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Staff
{
    public string Stafftc { get; set; } = null!;

    public string Stafffname { get; set; } = null!;

    public string Stafflname { get; set; } = null!;

    public string Staffpassword { get; set; } = null!;

    public string Staffposition { get; set; } = null!;

    public string Staffphone { get; set; } = null!;

    public int? Branchid { get; set; }

    public string Staffaddress { get; set; } = null!;

    public string Staffemail { get; set; } = null!;

    //public virtual Branch? Branch { get; set; }

    //public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    //public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
