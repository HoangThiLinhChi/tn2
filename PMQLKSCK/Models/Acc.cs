using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLKSCK.Models
{
    [Table("Accs")]
    public class Acc
    {
        [Key]
        public int IDacc { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        
        


    }
}