namespace catat.core.Models.DTO
{
    public class TransactionDto
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Guid BankAccountID { get; set; }
        public string TransactionType { get; set; }        
    }

    
}