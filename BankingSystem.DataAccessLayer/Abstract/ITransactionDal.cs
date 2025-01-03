﻿using BankingSystem.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.DataAccessLayer.Abstract
{
    public interface ITransactionDal : IGenericDal<Transaction>
    {
        List<Transaction> SearchTransaction(string customerTc);
    }
}
