using Aribilgi.BankApp.Web.Data.Enums;
using System;
using System.Collections.Generic;

namespace Aribilgi.BankApp.Web.Data.Entities
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public Account FromAccount { get; set; }
        public int ToAccountId { get; set; }
        public Account ToAccount { get; set; }
        public decimal Amount { get; set; }
        public TransactionStatu Statu { get; set; }
        public DateTime TransactionTime { get; set; }


    }
}
