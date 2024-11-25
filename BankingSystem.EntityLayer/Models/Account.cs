using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public char AccountType { get; set; }

    public int AccountBalance { get; set; }

    public char AccountIban { get; set; }

    public int AccountCurrency { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
