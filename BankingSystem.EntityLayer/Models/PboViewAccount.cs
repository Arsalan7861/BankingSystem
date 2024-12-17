using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class PboViewAccount
{
    public int? Accountid { get; set; }

    public string? Customertc { get; set; }

    public string? Accounttype { get; set; }

    public decimal? Accountbalance { get; set; }

    public string? Accountiban { get; set; }

    public string? Accountcurrency { get; set; }
}
