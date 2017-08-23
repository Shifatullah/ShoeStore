using ShoeStore.Products.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class ImageAsset : Asset
    {
        public int AssetId { get; set; }

        public ImageSize Size { get; set; }
    }
}
