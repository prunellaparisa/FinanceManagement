using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FinanceMobileApp
{
    public partial class ExpensesPage : ContentPage
    {
        private readonly HttpClient _httpClient;

        public ExpensesPage(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }

        private async void OnLoadExpensesClicked(object sender, EventArgs e)
        {
            var expenses = await _httpClient.GetFromJsonAsync<List<Expense>>("api/expenses");
            ExpensesListView.ItemsSource = expenses;
        }
    }

    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}