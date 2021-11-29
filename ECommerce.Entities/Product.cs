using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommerce.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productID { get; set; }
        [Required]
        [Range(1, 1000)]
        public int price { get; set; }
        [Required]
        [Range(0, 1000)]
        public int stock { get; set; }
    }
}
