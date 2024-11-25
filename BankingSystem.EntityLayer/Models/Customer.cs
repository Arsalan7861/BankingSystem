using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Customer
{
    public int CustomerTc { get; set; }

    public char CustomerFname { get; set; }

    public char CustomerLname { get; set; }

    public char CustomerPhonNo { get; set; }

    public char CustomerAddress { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

    public virtual ICollection<Transaction> TransactionTransactionFroms { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionTransactionTos { get; set; } = new List<Transaction>();
}
