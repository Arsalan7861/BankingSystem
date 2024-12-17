using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class TellerViewTransaction
{
    public int? Transactionid { get; set; }

    public string? Transactionfromtc { get; set; }

    public string? Transactiontotc { get; set; }

    public decimal? Transactionamount { get; set; }

    public DateTime? Transactiondate { get; set; }

    public string? Transactiondescription { get; set; }
}
