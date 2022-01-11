using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Models
{
    public class order
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sudentid { get; set; }
        public string Name { get; set; }
        public string roll_no { get; set; }
        public string Eamil { get; set; }
    }
}
