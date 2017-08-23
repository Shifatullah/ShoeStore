using Framework.Domain;
using ShoeStore.Products.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class Catalogue : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CatalogueState State { get; set; }
        public DateTime PublishedOn { get; set; }
        public AuditInfo AuditInfo { get; set; }
    }
}
