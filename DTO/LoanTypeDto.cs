using System.ComponentModel.DataAnnotations;

namespace LOAN_MANAGEMENT_API.DTO
{
    public class LoanTypeDto
    {
        public int id { get; set; } 
		[StringLength(50)]
		public string? name { get; set; }
		[StringLength(100)]
		public string? description { get; set; }
    }
}