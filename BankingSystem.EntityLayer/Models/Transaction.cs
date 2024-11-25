using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int TransactionFromId { get; set; }

    public int TransactionToId { get; set; }

    public int TransactionAmount { get; set; }

    public DateOnly TransactionDate { get; set; }

    public virtual Customer TransactionFrom { get; set; } = null!;

    public virtual Customer TransactionTo { get; set; } = null!;
}
