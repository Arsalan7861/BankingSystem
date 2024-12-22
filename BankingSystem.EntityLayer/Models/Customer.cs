using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Customer
{
    public string Customertc { get; set; } = null!;

    public string Customerfname { get; set; } = null!;

    public string Customerlname { get; set; } = null!;

    public string Customerpassword { get; set; } = null!;

    public string Customerphone { get; set; } = null!;

    public string Customeraddress { get; set; } = null!;

    public string? Stafftc { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    //public virtual Staff? StafftcNavigation { get; set; }

    //public virtual ICollection<Transaction> TransactionTransactionfromtcNavigations { get; set; } = new List<Transaction>();

    //public virtual ICollection<Transaction> TransactionTransactiontotcNavigations { get; set; } = new List<Transaction>();
}
