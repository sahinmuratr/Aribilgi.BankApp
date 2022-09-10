using Aribilgi.BankApp.Web.Data.Entities;
using Aribilgi.BankApp.Web.Data.Enums;
using Aribilgi.BankApp.Web.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Aribilgi.BankApp.Web.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IRepository<Transaction> _transactionRepo;
        private readonly IRepository<Account> _accountRepo;


        public TransactionController(IRepository<Transaction> transactionRepo, IRepository<Account> accountRepo)
        {
            _transactionRepo = transactionRepo;
            _accountRepo = accountRepo;
        }
        public IActionResult Index()
        {
            List<Transaction> list = _transactionRepo.GetAll();

            List<TransactionDTO> listDto = new();

            foreach (Transaction item in list)
            {
                listDto.Add(new TransactionDTO
                {
                    Id = item.Id,
                    Amount = item.Amount,
                    Statu = item.Statu,
                    TransactionTime = item.TransactionTime,
                    FromAccountId = item.FromAccountId,
                    FromAccount = _accountRepo.Get(x => x.Id == item.FromAccountId),
                    ToAccountId = item.ToAccountId,
                    ToAccount = _accountRepo.Get(x => x.Id == item.ToAccountId)
                });
            }
            return View(listDto);
        }
        public IActionResult Reject(int TransactionId, int FromAccountId, decimal Amount)
        {
            Account _fromAccount = _accountRepo.Get(x => x.Id == FromAccountId);
            _fromAccount.Balance += Amount;
            _accountRepo.Update(_fromAccount);


            Transaction _transaction = _transactionRepo.Get(x => x.Id == TransactionId);
            _transaction.Statu = TransactionStatu.Reddedildi;
            _transactionRepo.Update(_transaction);

            return RedirectToAction("Index", "Transaction");
        }
        public IActionResult Confirm(int TransactionId, int ToAccountId, decimal Amount)
        {
            Account _toAccount=_accountRepo.Get(x => x.Id == ToAccountId);
            _toAccount.Balance+=Amount;
            _accountRepo.Update(_toAccount);

            Transaction _transaction=_transactionRepo.Get(x => x.Id == TransactionId);
            _transaction.Statu= TransactionStatu.Onaylandi;
            _transactionRepo.Update(_transaction);
            return RedirectToAction("Index", "Transaction");    
        }
    }
}
