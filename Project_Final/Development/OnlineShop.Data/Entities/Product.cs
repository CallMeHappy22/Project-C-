﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Entities
{
    
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DataCreated { get; set; }   
        public int SaleAlias { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
/*ConfigURE theo attribute
 * using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 * [Table("Products")]
 * 
 *  [Required]
 */

/*Configure entity
 * Fluent API Configuration
 * 
 */