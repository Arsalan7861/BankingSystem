using System;
using System.Collections.Generic;

namespace BankingSystem.EntityLayer.Models;

public partial class Customer
{
    public string Customertc { get; set; } = null!;

    public string Customerfname { get; set; } = null!;

    public string Customerlname { get; set; } = null!;

    public string Customerphone { get; set; } = null!;

    public string Customeraddress { get; set; } = null!;

    public virtual ICollection<Account> Account { get; set; } = new List<Account>();

    public virtual ICollection<Log> Log { get; set; } = new List<Log>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

    public virtual ICollection<Transaction> TransactionTransactionfromtcNavigation { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionTransactiontotcNavigation { get; set; } = new List<Transaction>();
}
