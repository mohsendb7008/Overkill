namespace Overkill.Domains.Bank;

public class Loan(decimal loanAmount, decimal installmentAmount)
{
    public Guid LoanId { get; set; } = Guid.NewGuid();
    public decimal LoanAmount { get; set; } = loanAmount;
    public decimal RemainingAmount { get; set; } = loanAmount;
    public DateTime LoanDate { get; set; } = DateTime.Now;
    public decimal InstallmentAmount { get; set; } = installmentAmount;
}