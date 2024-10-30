using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOAN_MANAGEMENT_API.Model
{
    [Table("user_tbl")]
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? username { get; set; }
        [Required]
        public string? password { get; set; }
        [Required]
        public string? email { get; set; }
        public string? fullname { get; set; }
        [Required]
        public DateTime dateadd { get; set; }
        [Required]
        public DateTime expiredate { get; set; }
    }
}