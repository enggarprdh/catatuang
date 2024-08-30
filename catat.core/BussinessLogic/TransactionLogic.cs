using catat.core.Models.DTO;
using catat.core.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace catat.core.BussinessLogic
{

    public static class TransactionLogic
    {
        public static void DoTransaction(TransactionDto transactionDto)
        {
            var context = new MainDataContext();
            var cashSummary = new CashSummaryEntity();
            cashSummary.CashSummaryID = Guid.NewGuid();
            cashSummary.TransactionDate = transactionDto.Date;
            cashSummary.BankAccountID = transactionDto.BankAccountID;
            cashSummary.Description = transactionDto.Description;
            if (transactionDto.TransactionType.ToUpper() == "IN")
                cashSummary.CashIn = transactionDto.Amount;
            else if (transactionDto.TransactionType.ToUpper() == "OUT")
                cashSummary.CashOut = transactionDto.Amount;
            cashSummary.CreatedOn = DateTime.Now;
            cashSummary.CreatedBy = "System";
            cashSummary.Deleted = false;
            context.Add(cashSummary);
            context.SaveChanges();
            
        }
    }

}