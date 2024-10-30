namespace LOAN_MANAGEMENT_API.DTO
{
    public class LoanPlanDto
    {
        public int id { get; set; } 
        public int month { get; set; }  
        public float interest { get; set; }   
        public int penalty { get; set; }
    }
}