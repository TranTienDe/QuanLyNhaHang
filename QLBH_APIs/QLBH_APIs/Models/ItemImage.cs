using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Models
{
    /// <summary>
    /// Chứa các hình cho các món ăn.
    /// </summary>
    public class ItemImage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } //tên hình
        public string Data { get; set; } //Link hình
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
    }
}
