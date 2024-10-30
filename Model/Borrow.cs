using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Namespace
{
    [Table("tbl_borrow")]
    public class Borrow
    {
        [Key]
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