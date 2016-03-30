using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataProductService.Models
{
    public partial class Current_Product_List
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
