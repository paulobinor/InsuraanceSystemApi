namespace EHR.AppService.Dtos
{
    public class ExpenseDto
    {
        public string ExpenseType { get; set; }
        public string ExpenseDescription { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }

    }
}