using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMQLKSCK.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string Ma_Kh { get; set; }
        public string Ho_Kh { get; set; }
        [AllowHtml]
        public string Ten_Kh { get; set; }
        public string SoCMT { get; set; }
        [AllowHtml]
        public string SĐT { get; set; }
    }
}