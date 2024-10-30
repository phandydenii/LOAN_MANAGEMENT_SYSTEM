namespace LOAN_MANAGEMENT_API.DTO
{
    public class LoanDto
    {
         public int id { get; set; } 
        public string? references_no { get; set; }
        public int type_id { get; set; } 
        public int borrow_id { get; set; } 
        public string? purpose { get; set; }
        public double amount { get; set; }
        public int plan_id { get; set; } 
        public int status { get; set; }
        public DateTime date_release { get; set; }
        public DateTime date_create { get; set; }
    }
}