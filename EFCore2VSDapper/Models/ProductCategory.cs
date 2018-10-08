using System;
using System.Collections.Generic;

namespace EFCore2VSDapper.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            InverseParentProductCategory = new HashSet<ProductCategory>();
            Product = new HashSet<Product>();
        }

        public int ProductCategoryId { get; set; }
        public int? ParentProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ProductCategory ParentProductCategory { get; set; }
        public ICollection<ProductCategory> InverseParentProductCategory { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
