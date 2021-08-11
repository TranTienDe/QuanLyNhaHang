using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Models
{
    /// <summary>
    /// Phiếu order
    /// </summary>
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; } //Số phiếu order.
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
        public bool Voided { get; set; }  //Hủy bỏ
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public virtual IList<OrderItem> OrderItem { get; set; } //Danh sách mặt hàng
    }
}
