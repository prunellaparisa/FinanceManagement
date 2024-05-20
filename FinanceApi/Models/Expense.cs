namespace FinanceApi.Models
{
    public class Expense : Transaction
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public int UserId { get; set; }
    }
}