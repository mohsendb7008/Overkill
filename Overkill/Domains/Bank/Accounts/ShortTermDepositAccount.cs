using System;

namespace MyBank.Accounts
{
    public class ShortTermDepositAccount : DepositAccount
    {
        public ShortTermDepositAccount(
            decimal amount,
            string firstName,
            string lastName,
            string nationalID,
            string phoneNumber,
            string email,
            DateTime dateOfBirth,
            decimal profit
        ) : base(amount, firstName, lastName, nationalID, phoneNumber, email, dateOfBirth, profit)
        {
        }

        public override string GetAccountType()
        {
            return "Short-Term Deposit Account";
        }

        public override string DepositType { get; set; } = "Short-Term";
    }
}