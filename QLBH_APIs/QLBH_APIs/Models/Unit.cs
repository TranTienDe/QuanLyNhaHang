﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Models
{
    /// <summary>
    /// Đơn vị mặt hàng
    /// </summary>
    public class Unit
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public UnitType UnitType { get; set; } //Loại Nước đóng chai or loong.
    }
}
