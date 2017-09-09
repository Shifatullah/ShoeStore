using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class Asset : IAggregateRoot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public AuditInfo AuditInfo { get; set; }
    }
}
