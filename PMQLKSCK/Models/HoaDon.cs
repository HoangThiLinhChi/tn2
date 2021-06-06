using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLKSCK.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string Ma_HD { get; set; }
        public string Ten_HD { get; set; }
        public string NgayTT { get; set; }
        public string ThanhTien { get; set; }
        public string Ma_Kh { get; set; }
    }
}