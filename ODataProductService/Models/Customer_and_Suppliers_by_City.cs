using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataProductService.Models
{
    public partial class Customer_and_Suppliers_by_City
    {
        [Key]
        [Column(Order = 1)]
        public string City { get; set; }
        [Key]
        [Column(Order = 2)]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
