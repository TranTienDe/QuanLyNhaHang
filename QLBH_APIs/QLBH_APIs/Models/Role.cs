using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH_APIs.Models
{
    /// <summary>
    /// Bảng chứa vai trò như Admin, Caster.
    /// </summary>
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
    }
}
