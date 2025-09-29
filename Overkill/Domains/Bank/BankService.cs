using System.Security.Cryptography;

namespace Overkill.Domains.Bank;

public class BankService
{
    private List<Account> _accounts = new List<Account>();

    public void CreateAccount(Account account)
    {
        if (_accounts.Any(a => a.AccountId == account.AccountId))
        {
            Console.WriteLine("[ERROR] Duplicate account number");
            return;
        }

        if (account is CurrentAccount ca && _accounts.Where(a => a is CurrentAccount).Cast<CurrentAccount>()
                .Any(a => a.NationalID == ca.NationalID))
        {
            Console.WriteLine("[ERROR] There is a current account for this national id");
            return;
        }
            
        _accounts.Add(account);
        Console.WriteLine($"[SUCCESS] Account {account.AccountId} created successfully");
    }

    public void Deposit(Guid accountId, decimal amount)
    {
        var account = _accounts.Find(a => a.AccountId == accountId);
        if (account == null)
        {
            Console.WriteLine("[Error] Account not found");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("[ERROR] Deposit amount can not be negative");
            return;
        }

        account.Amount += amount;
        Console.WriteLine($"[SUCCESS] Amount of {amount}$ deposited to {account.AccountId}");
    }

    public void Withdraw(Guid accountId, decimal amount)
    {
        var account = _accounts.Find(a => a.AccountId == accountId);
        if (account == null)
        {
            Console.WriteLine("[Error] Account not found");
            return;
        }

        if (amount <= 0)
        {
            Console.WriteLine("[ERROR] Withdraw amount can not be negative");
            return;
        }

        if (amount > account.Amount)
        {
            Console.WriteLine("[ERROR] Insufficient funds.");
            return;
        }

        account.Amount -= amount;
        Console.WriteLine($"[SUCCESS] Amount of {amount}$ withdrew from {account.AccountId}");
    }

    public void TransferFunds(Guid sourceAccountId, Guid destinationAccountId, decimal amount)
    {
        var sourceAccount = _accounts.Find(a => a.AccountId == sourceAccountId);
        var destinationAccount = _accounts.Find(a => a.AccountId == destinationAccountId);
        if (sourceAccount == null || destinationAccount == null)
        {
            Console.WriteLine("[ERROR] Source or destination account not found.");
            return;
        }

        if (amount > sourceAccount.Amount)
        {
            Console.WriteLine("[ERROR] Insufficient funds in source account.");
            return;
        }

        sourceAccount.Amount -= amount;
        destinationAccount.Amount += amount;
        Console.WriteLine($"[SUCCESS] Amount of {amount}$ transferred from {sourceAccount.AccountId} to {destinationAccount.AccountId}");
    }

    public void CardToCardTransfer(string sourceCardNumber, string destinationCardNumber, decimal amount)
    {
        var cardLookup = new Dictionary<string, Account>();
        foreach (var account in _accounts.Where(a => a is CurrentAccount).Cast<CurrentAccount>())
        {
            cardLookup.Add(account.BankCard.CardNumber, account);
        }
        foreach (var account in _accounts.Where(a => a is QarzAlHasanahAccount).Cast<QarzAlHasanahAccount>())
        {
            cardLookup.Add(account.BankCard.CardNumber, account);
        }

        if (!cardLookup.TryGetValue(sourceCardNumber, out var sourceAccount) || !cardLookup.TryGetValue(destinationCardNumber, out var destinationAccount))
        {
            Console.WriteLine("[ERROR] Source or destination card not found.");
            return;
        }

        var validTypes = new List<string>
        {
            "Current Account",
            "Qarz-al-Hasanah Account"
        };
        if (!validTypes.Contains(sourceAccount.GetAccountType()) ||
            !validTypes.Contains(destinationAccount.GetAccountType()))
        {
            Console.WriteLine("[ERROR] account type not supported for card transfer.");
            return;
        }

        if (amount > sourceAccount.Amount)
        {
            Console.WriteLine("[ERROR] Insufficient funds in source account.");
            return;
        }

        sourceAccount.Amount -= amount;
        destinationAccount.Amount += amount;
        Console.WriteLine($"[SUCCESS] Amount of {amount}$ transferred from card {sourceCardNumber} to {destinationCardNumber}");
    }

    public void RequestBankCard(Guid accountId)
    {
        var account = _accounts.Find(a => a.AccountId == accountId);
        if (account == null)
        {
            Console.WriteLine("[ERROR] Account not found.");
            return;
        }

        if (account is CurrentAccount || account is QarzAlHasanahAccount)
        {
            Console.WriteLine("[ERROR] Bank card can only be requested for CurrentAccount or QarzAlHasanahAccount.");
            return;
        }

        var bankCard = new BankCard(RandomNumberGenerator.GetString("1234567890", 16));
        switch (account)
        {
            case CurrentAccount ca:
                ca.BankCard = bankCard;
                break;
            case QarzAlHasanahAccount qa:
                qa.BankCard = bankCard;
                break;
        }
        Console.WriteLine($"[SUCCESS] New bank card {bankCard.CardNumber} issued for account {accountId}. Expiry Date: {bankCard.ExpirationDate}");
    }

    public List<Account> GetAccounts()
    {
        return _accounts;
    }

    public void ClearAccounts()
    {
        _accounts.Clear();
    }
}