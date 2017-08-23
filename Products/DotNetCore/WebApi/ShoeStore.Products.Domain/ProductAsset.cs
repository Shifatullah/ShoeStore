using Framework.Domain;
using ShoeStore.Products.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class ProductAsset : IAggregate
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public ProductAssetType AssetType { get; set; }
        public int AssetId { get; set; }
        public AuditInfo AuditInfo { get; set; }
    }
}
