using FinanceApi.Models;
using FinanceApi;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllTransactionsAsync();
    Task AddTransactionAsync(Transaction transaction);
}