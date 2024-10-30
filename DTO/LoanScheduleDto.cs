namespace LOAN_MANAGEMENT_API.DTO
{
    public class LoanScheduleDto
    {
        public int loan_schedule_id { get; set; } 
        public int loan_id { get; set; }  
        public DateTime date { get; set; }
    }
}