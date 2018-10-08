using System;
using System.Collections.Generic;

namespace EFCore2VSDapper.Models
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            Product = new HashSet<Product>();
            ProductModelProductDescription = new HashSet<ProductModelProductDescription>();
        }

        public int ProductModelId { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<ProductModelProductDescription> ProductModelProductDescription { get; set; }
    }
}
