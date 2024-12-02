using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Account
{
    public int Accountid { get; set; }

    public string Customertc { get; set; } = null!;

    public string Accounttype { get; set; } = null!;

    public decimal Accountbalance { get; set; }

    public string Accountiban { get; set; } = null!;

    public string Accountcurrency { get; set; } = null!;

    public virtual Customer CustomertcNavigation { get; set; } = null!;
}
