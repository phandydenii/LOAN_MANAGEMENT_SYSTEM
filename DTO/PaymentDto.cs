namespace LOAN_MANAGEMENT_API.DTO
{
    public class PaymentDto
    {
        public int id { get; set; }
        public int loan_id { get; set; } 
        public string? payee { get; set; }
        public float pay_amount { get; set; }
        public float penalty { get; set; }
        public int overdue { get; set; }
        public DateTime date_create { get; set; }
    }
}