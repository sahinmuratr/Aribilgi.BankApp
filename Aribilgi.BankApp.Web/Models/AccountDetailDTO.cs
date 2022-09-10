using Aribilgi.BankApp.Web.Data.Entities;
using System.Collections.Generic;

namespace Aribilgi.BankApp.Web.Models
{
    public class AccountDetailDTO
    {
        public decimal Balance { get; set; }
        public int TransactionCount { get; set; }
        public int InTransactionCount { get; set; }
        public int OutTransactionCount { get; set; }

        public List<TransactionDTO> TransactionList { get; set; }
    }
}
