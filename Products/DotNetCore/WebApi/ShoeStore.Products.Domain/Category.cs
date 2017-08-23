using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class Category : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int ParentCategoryId { get; set; }
        public int Rank { get; set; }
        public AuditInfo AuditInfo { get; set; }    
    }
}
