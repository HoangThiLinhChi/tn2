using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLKSCK.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string Ma_Nv { get; set; }
        public string Ho_Nv { get; set; }
        public string Ten_Nv { get; set; }
        public string ChucVu { get; set; }
        public string SoCMT { get; set; }
        public string DiaChi { get; set; }

    }
}