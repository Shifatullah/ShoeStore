using Framework.Domain;
using RangeHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class ProductPrice : IAggregate
    {
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public DateRange Range { get; set; }
    }
}
