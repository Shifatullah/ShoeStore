using Framework.Domain;
using ShoeStore.Products.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class ProductAsset : IEntity
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public ProductAssetType AssetType { get; set; }
        public int AssetId { get; set; }
        public AuditInfo AuditInfo { get; set; }
    }
}
