﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Models
{
    /// <summary>
    /// Chi tiết món hàng bán trong order.
    /// </summary>
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public bool Voided { get; set; }  //Hủy bỏ
        public double SalePrice { get; set; }      
        public virtual Item Item { get; set; } //Tên món
    }
}
