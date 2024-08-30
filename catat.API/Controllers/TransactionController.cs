using System;
using catat.core.BussinessLogic;
using catat.core.Models.DTO;
using catat.core.Models.Enums.Message;
using Microsoft.AspNetCore.Mvc;

namespace catat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Transaction : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody] TransactionDto transactionDto)
        {
            var result = new Result<string>();

            try
            {
                if (transactionDto.Date == null)
                    throw new Exception(ResponseTransactionMessage.TRANSACTION_DATE_EMPTY);
                if (transactionDto.Amount == 0)
                    throw new Exception(ResponseTransactionMessage.TRANSACTION_AMOUNT_EMPTY);
                if (transactionDto.BankAccountID == Guid.Empty)
                    throw new Exception(ResponseTransactionMessage.TRANSACTION_BANK_ACCOUNT_EMPTY);
                if (string.IsNullOrEmpty(transactionDto.TransactionType))
                    throw new Exception(ResponseTransactionMessage.TRANSACTION_TYPE_EMPTY);

                TransactionLogic.DoTransaction(transactionDto);

                result.Message = ResponseMessage.SUCCESS;
                return Ok(result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return BadRequest(result);
            }

        }
    }
}




