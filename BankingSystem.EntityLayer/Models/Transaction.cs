using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Transaction
{
    public int Transactionid { get; set; }

    public string Transactionfromtc { get; set; } = null!;

    public string Transactiontotc { get; set; } = null!;

    public decimal Transactionamount { get; set; }

    public DateTime Transactiondate { get; set; }

    public string Transactiondescription { get; set; } = null!;

    public virtual Customer TransactionfromtcNavigation { get; set; } = null!;

    public virtual Customer TransactiontotcNavigation { get; set; } = null!;
}
