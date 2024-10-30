using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOAN_MANAGEMENT_API.Model
{
	[Table("tbl_loan_type")]
	public class LoanType
	{
		[Key]
		public int id { get; set; }

		[Required]
		[StringLength(50)]
		public string? name { get; set; }
		[StringLength(100)]
		public string? description { get; set; }
	}
}

