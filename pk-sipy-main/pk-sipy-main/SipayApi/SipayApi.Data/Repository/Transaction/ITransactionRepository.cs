using Microsoft.EntityFrameworkCore;
using SipayApi.Data.Domain;
using System.Linq.Expressions;

namespace SipayApi.Data.Repository;

public interface ITransactionRepository : IGenericRepository<Transaction>
{
    List<Transaction> GetByReference(string reference);
    IEnumerable<Transaction> Expression(int? accountNumber, decimal? minAmountCredit, decimal? maxAmountCredit, decimal? minAmountDebit, decimal? maxAmountDebit, string description, DateTime? beginDate, DateTime? endDate, string? referenceNumber);
    
}
