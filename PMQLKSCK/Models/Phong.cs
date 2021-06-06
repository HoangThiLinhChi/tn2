using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLKSCK.Models
{
    [Table("Phongs")]
    public class Phong
    {
        [Key] // lưu ý là khóa chính thì ko nen de kieu string - url no ko hiểu
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string GiaPhong { get; set; }
        public string LoaiPhong { get; set; }
    }
}