namespace Overkill.Domains.Bank;

public class Loan
{
    public Guid LoanId { get; set; } = Guid.NewGuid();
    public decimal LoanAmount { get; set; }
    public decimal RemainingAmount { get; set; }
    public DateTime LoanDate { get; set; } = DateTime.Now;
    public decimal InstallmentAmount { get; set; }

    public Loan(decimal loanAmount, decimal installmentAmount)
    {
        LoanAmount = loanAmount;
        RemainingAmount = loanAmount;
        InstallmentAmount = installmentAmount;
    }
}