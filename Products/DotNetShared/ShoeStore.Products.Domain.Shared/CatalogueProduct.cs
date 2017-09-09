using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class CatalogueProduct : IEntity
    {
        public int CatalogueId { get; set; }
        public Catalogue Catalogue { get; set; }
        public int ProductId { get; set; }
        public AuditInfo AuditInfo { get; set; }
    }
}
