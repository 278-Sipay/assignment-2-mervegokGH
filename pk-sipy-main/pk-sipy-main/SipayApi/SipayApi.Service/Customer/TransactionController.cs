
using Microsoft.AspNetCore.Mvc;
using SipayApi.Base;
using SipayApi.Data.Domain;
using SipayApi.Data.Repository;


namespace SipayApi.Service;



[ApiController]
[Route("sipy/api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionRepository repository;
   
    public TransactionController(ITransactionRepository repository )
    {
        this.repository = repository;
       
    }

   
    [HttpGet("GetByParameter")]
    public IActionResult GetByParameter([FromQuery] int? accountNumber, [FromQuery] decimal? minAmountCredit, [FromQuery] decimal? maxAmountCredit, [FromQuery] decimal? minAmountDebit, [FromQuery] decimal? maxAmountDebit, [FromQuery] string description, [FromQuery] DateTime? beginDate, [FromQuery] DateTime? endDate, [FromQuery] string? referenceNumber)
    {
        var expression = repository.Expression(accountNumber, minAmountCredit, maxAmountCredit, minAmountDebit, maxAmountDebit, description, beginDate, endDate, referenceNumber);
        return Ok(expression);
    }

}
