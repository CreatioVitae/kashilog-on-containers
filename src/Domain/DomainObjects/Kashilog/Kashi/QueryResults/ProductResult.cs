using DomainObject.Kashilog.ConstantValues.Kashi;
using DomainObject.Kashilog.Enterprise;
using DomainObject.Kashilog.Kashi.Entities;
using System;
using System.Collections.Generic;

namespace DomainObject.Kashilog.Kashi.QueryResults;

public class ProductResult(Product product,
    Company maker, Company publisher, IEnumerable<ProductTexture> textures, IEnumerable<ProductTaste> tastes) {
    public int ProductId { get; init; } = product.ProductId;

    public int ProductRevision { get; init; } = product.ProductRevision;

    public DateTime ValidBeginDateTime { get; init; } = product.ValidBeginDateTime;

    public DateTime ValidEndDateTime { get; init; } = product.ValidEndDateTime;

    public string ProductName { get; init; } = product.ProductName;

    public string LargeCategory { get; init; } = product.LargeCategory.GetDisplayValue();

    public string MiddleCategory { get; init; } = product.MiddleCategory.GetDisplayValue();

    public string SmallCategory { get; init; } = product.SmallCategory.GetDisplayValue();

    public decimal UnitPrice { get; set; } = product.UnitPrice;

    public decimal Amount { get; set; } = product.Amount;

    public string AmountType { get; init; } = product.AmountType.GetDisplayValue();

    public string Description { get; init; } = product.Description;

    public Company Maker { get; init; } = maker;

    public Company Publisher { get; set; } = publisher;

    public IEnumerable<ProductTexture> Textures { get; init; } = textures;

    public IEnumerable<ProductTaste> Tastes { get; init; } = tastes;
}
