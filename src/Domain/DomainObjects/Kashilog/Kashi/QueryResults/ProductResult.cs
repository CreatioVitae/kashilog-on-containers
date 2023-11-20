using DomainObject.Kashilog.ConstantValues.Kashi;
using DomainObject.Kashilog.Enterprise;
using DomainObject.Kashilog.Kashi.Entities;
using System;
using System.Collections.Generic;

namespace DomainObject.Kashilog.Kashi.QueryResults {
    public class ProductResult {
        public int ProductId { get; set; }

        public int ProductRevision { get; set; }

        public DateTime ValidBeginDateTime { get; set; }

        public DateTime ValidEndDateTime { get; set; }

        public string ProductName { get; set; } = default!;

        //Todo:Enum Values
        public string LargeCategory { get; set; } = default!;

        //Todo:Enum Values
        public string MiddleCategory { get; set; } = default!;

        //Todo:Enum Values
        public string SmallCategory { get; set; } = default!;

        public decimal UnitPrice { get; set; }

        public decimal Amount { get; set; }

        public string AmountType { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Company Maker { get; set; }

        public Company Publisher { get; set; }

        public IEnumerable<ProductTexture> Textures { get; set; }

        public IEnumerable<ProductTaste> Tastes { get; set; }

        public ProductResult(
            Product product,
            Company maker, Company publisher, IEnumerable<ProductTexture> textures, IEnumerable<ProductTaste> tastes) {

            ProductId = product.ProductId;

            ProductRevision = product.ProductRevision;

            ValidBeginDateTime = product.ValidBeginDateTime;

            ValidEndDateTime = product.ValidEndDateTime;

            ProductName = product.ProductName;

            LargeCategory = product.LargeCategory.GetLargeCategoryDisplayValue();

            MiddleCategory = MiddleCategoryResource.DisplayNames.GetValueOrDefault(product.MiddleCategory)
                ?? throw new NullReferenceException($"{nameof(MiddleCategoryResource.DisplayNames)}-{nameof(MiddleCategory)}");

            SmallCategory = SmallCategoryResource.DisplayNames.GetValueOrDefault(product.SmallCategory)
                ?? throw new NullReferenceException($"{nameof(SmallCategoryResource.DisplayNames)}-{nameof(SmallCategory)}");

            UnitPrice = product.UnitPrice;
            Amount = product.Amount;

            AmountType = product.AmountType.GetAmountTypeDisplayValue();

            Description = product.Description;

            Maker = maker;

            Publisher = publisher;

            Textures = textures;

            Tastes = tastes;
        }
    }
}
