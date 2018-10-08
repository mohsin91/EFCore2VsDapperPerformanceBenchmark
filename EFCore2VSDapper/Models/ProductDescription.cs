using System;
using System.Collections.Generic;

namespace EFCore2VSDapper.Models
{
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            ProductModelProductDescription = new HashSet<ProductModelProductDescription>();
        }

        public int ProductDescriptionId { get; set; }
        public string Description { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<ProductModelProductDescription> ProductModelProductDescription { get; set; }
    }
}
