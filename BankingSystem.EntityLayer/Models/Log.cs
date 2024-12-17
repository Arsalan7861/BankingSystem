using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Log
{
    public int Logid { get; set; }

    public string Logtype { get; set; } = null!;

    public DateTime Logdatetime { get; set; }

    public string? Stafftc { get; set; }

    public string Customertc { get; set; } = null!;

    public decimal Oldbalance { get; set; }

    public decimal Newbalance { get; set; }

    public virtual Customer CustomertcNavigation { get; set; } = null!;

    public virtual Staff? StafftcNavigation { get; set; }
}
