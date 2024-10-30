using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Namespace
{
    [Table("tbl_payment")]
    public class Payment
    {
        [Key]
        public int id { get; set; }
        public int loan_id { get; set; } 
        public string? payee { get; set; }
        public float pay_amount { get; set; }
        public float penalty { get; set; }
        public int overdue { get; set; }
        public DateTime date_create { get; set; }
    }
}