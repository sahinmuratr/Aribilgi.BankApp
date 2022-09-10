using Aribilgi.BankApp.Web.Data.Contexts;
using Aribilgi.BankApp.Web.Data.Entities;
using Aribilgi.BankApp.Web.Data.Enums;
using Aribilgi.BankApp.Web.Data.Interfaces;
using Aribilgi.BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aribilgi.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {

        private readonly IRepository<ApplicationUser> _userRepo;
        private readonly IRepository<Account> _accountRepo;
        private readonly IRepository<Transaction> _transactionRepo;


        public AccountController(IRepository<ApplicationUser> userRepo, IRepository<Account> accountRepo, IRepository<Transaction> transactionRepo)
        {
            _userRepo = userRepo;
            _accountRepo = accountRepo;
            _transactionRepo = transactionRepo;
        }

        public IActionResult Index(int UserId)
        {
            ApplicationUser user = _userRepo.Get(x => x.Id == UserId);
            user.Accounts = _accountRepo.GetAll(x => x.ApplicationUserId == UserId);


            return View(user);
        }
        public IActionResult Detail(int AccountId)
        {
            AccountDetailDTO _account = new();
            _account.Balance = _accountRepo.Get(x => x.Id == AccountId).Balance;
            _account.TransactionCount = _transactionRepo.GetAll(x => x.FromAccountId == AccountId || x.ToAccountId == AccountId).Count;
            _account.InTransactionCount = _transactionRepo.GetAll(x => x.FromAccountId == AccountId).Count;
            _account.OutTransactionCount = _transactionRepo.GetAll(x => x.ToAccountId == AccountId).Count;


            List<TransactionDTO> listDto = new();
            List<Transaction> list = _transactionRepo.GetAll(x => x.FromAccountId == AccountId || x.ToAccountId == AccountId);

            foreach (Transaction item in list)
            {
                listDto.Add(new TransactionDTO
                {
                    Id = item.Id,
                    Amount = item.Amount,
                    TransactionTime = item.TransactionTime,
                    FromAccount = _accountRepo.Get(x => x.Id == item.FromAccountId),
                    ToAccount = _accountRepo.Get(x => x.Id == item.ToAccountId),
                    Statu=item.Statu
                });
            }
            //lmklmö
            _account.TransactionList=listDto;

            return View(_account);
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            _accountRepo.Add(account);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult SendMoney(int fromAccount, int toAccount, decimal amount)
        {
            Account _fromAccount = _accountRepo.Get(x => x.Id == fromAccount);
            Account _toAccount = null;
            if (_fromAccount.Balance < amount)
            {
                return View(false);
            }
            if (!_accountRepo.Any(x => x.AccountNumber == toAccount))
            {
                return View(false);
            }
            _toAccount = _accountRepo.Get(x => x.AccountNumber == toAccount);
            _fromAccount.Balance -= amount;
            _accountRepo.Update(_fromAccount);

            Transaction transaction = new();
            transaction.FromAccountId = _fromAccount.Id;
            transaction.TransactionTime = DateTime.Now;
            transaction.Statu = TransactionStatu.Beklemede;
            transaction.Amount = amount;
            transaction.ToAccountId = _toAccount.Id;
            _transactionRepo.Add(transaction);

            return RedirectToAction("Index", "Home");


        }
    }
}
