using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ViThuyVy.Models
{
    [Table("Sanphams")]
    public class SanPham
    {
        [Key]
        public string  Masanpham { get; set; }
        public string TenSanPham { get; set; }
        public string MaNhaCungCap { get; set; }
    }
}