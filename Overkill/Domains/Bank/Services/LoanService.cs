using System;
using System.Collections.Generic;
using System.Linq;
using MyBank.Accounts;
using MyBank.Models;

namespace MyBank.Services
{
    public class LoanService
    {
        private Dictionary<Guid, Loan> _loans = new Dictionary<Guid, Loan>();
        private BankService _bankService; // Dependency for accessing accounts

        public LoanService(BankService bankService)
        {
            _bankService = bankService;
        }

        public void RequestLoan(Guid accountId, decimal loanAmount, decimal installmentAmount)
        {
            // todo
        }

        public void PayLoanInstallments(Guid accountId)
        {
            // todo
        }

        public void ClearLoans()
        {
            _loans.Clear();
        }
    }
}