﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    enum TransactionType
    {
        Credit,
        Debit
    }
    class Transaction
    {

        public int TansactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Description { get; set; }
        public TransactionType TransactionType { get; set; }
        public virtual Account  Account { get; set; }
    }
}