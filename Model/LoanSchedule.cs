using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks; 

namespace Namespace
{
    [Table("tbl_loan_schedule")]
    public class LoanSchedule
    {
        [Key]
        public int loan_schedule_id { get; set; }
        [Required]
        public int loan_id { get; set; }  
        public DateTime date { get; set; }
    }
}