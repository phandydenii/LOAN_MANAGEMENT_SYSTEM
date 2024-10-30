using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Namespace
{
    [Table("tbl_loan_plan")]
    public class LoanPlan
    {
        [Key]
        public int id { get; set; } 
        public int month { get; set; }  
        public float interest { get; set; }   
        public int penalty { get; set; }
    }
}