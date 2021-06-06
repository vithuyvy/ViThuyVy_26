using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ViThuyVy.Models
{ 
    [Table("Nhacungcaps")]
    public class Nhacungcap
    {
        [Key]
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
    }
}