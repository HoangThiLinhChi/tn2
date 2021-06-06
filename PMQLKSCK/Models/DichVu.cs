using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLKSCK.Models
{
    [Table("DichVus")]
    public class DichVu
    {
        [Key]
        public string Ma_Dv { get; set; }
        public string Ten_Dv { get; set; }
        public string Gia { get; set; }
    }
}