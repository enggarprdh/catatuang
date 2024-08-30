using System.ComponentModel.DataAnnotations;

namespace catat.core.Models.Entities
{
    public class CashSummaryEntity : ShareEntity
    {
        public const string TableName = "CashSummary";
        public const string CashSummaryIDField = "CashSummaryID";
        public const string DescriptionField = "Description";
        public const string BankAccountIDField = "BankAccountID";
        public const string CashInField = "CashIn";
        public const string CashOutField = "CashOut";
        public const string CreatedOnField = "CreatedOn";
        public const string CreatedByField = "CreatedBy";
        public const string ModifiedOnField = "ModifiedOn";
        public const string ModifiedByField = "ModifiedBy";
        public const string DeletedField = "Deleted";
        public const string TransactionDateField = "TransactionDate";

        [Key]
        public Guid CashSummaryID { get; set; }
        public Guid BankAccountID { get; set; }
        public string? Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal CashIn { get; set; }
        public decimal CashOut { get; set; }
    }
}