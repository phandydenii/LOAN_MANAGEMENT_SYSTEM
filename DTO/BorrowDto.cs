using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace LOAN_MANAGEMENT_API.DTO
{
    public class BorrowDto
    {
        public int id { get; set; }
        [StringLength(100)]
        public string? first_name { get; set; }
        [StringLength(100)]
        public string? last_name { get; set; }
        [StringLength(20),AllowNull]
        public string? contact_name { get; set; }

        [StringLength(200),AllowNull]
        public string? address { get; set; }
        [StringLength(50),AllowNull]
        public string? email { get; set; } 
    }
}