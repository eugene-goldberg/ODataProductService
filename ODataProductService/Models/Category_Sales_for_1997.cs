using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataProductService.Models
{
    public partial class Category_Sales_for_1997
    {
        [Key]
        public string CategoryName { get; set; }
        public Nullable<decimal> CategorySales { get; set; }
    }
}
