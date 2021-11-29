using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderID { get; set; }
        [Required]
        [Range(1, 1000)]
        public int productID { get; set; }
        [Required]
        [Range(1, 1000)]
        public int quantity { get; set; }
    }
}
