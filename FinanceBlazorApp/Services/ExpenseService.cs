using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FinanceBlazorApp.Models;

public class ExpenseService
{
    private readonly HttpClient _httpClient;

    public ExpenseService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Expense>> GetExpensesAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Expense>>("api/expenses");
    }

    public async Task<Expense> AddExpenseAsync(Expense expense)
    {
        var response = await _httpClient.PostAsJsonAsync("api/expenses", expense);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Expense>();
    }
}