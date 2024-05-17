namespace FinanceApi.Models
{
    public class Budget : Transaction
    {
        public string Category { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
    }
}