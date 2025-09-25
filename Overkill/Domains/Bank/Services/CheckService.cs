using System;
using System.Linq;
using MyBank.Accounts;
using MyBank.Models;
using System.Collections.Generic;

namespace MyBank.Services
{
    public class CheckService
    {
        private BankService _bankService;

        public CheckService(BankService bankService)
        {
            _bankService = bankService;
        }

        public void RequestCheckbook(Guid accountId, int numberOfChecks)
        {
            // todo
        }

        public void WriteCheck(Guid accountId, decimal amount, Guid recipientAccountId)
        {
            // todo
        }

        public void CheckClearance(Guid accountId, Guid checkId)
        {
            // todo
        }
    }
}