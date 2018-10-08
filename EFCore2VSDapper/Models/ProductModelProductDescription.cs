using System;
using System.Collections.Generic;

namespace EFCore2VSDapper.Models
{
    public partial class ProductModelProductDescription
    {
        public int ProductModelId { get; set; }
        public int ProductDescriptionId { get; set; }
        public string Culture { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ProductDescription ProductDescription { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
