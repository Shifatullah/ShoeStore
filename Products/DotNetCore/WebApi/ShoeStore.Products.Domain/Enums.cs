using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain.Enums
{
    public enum ImageSize
    {
        Small,
        Medium,
        Large
    }

    public enum CatalogueState
    {
        Draft,
        Published
    }

    public enum ProductAssetType
    {
        Thumbnail,
        ProductPage,
        Zoom
    }
}
