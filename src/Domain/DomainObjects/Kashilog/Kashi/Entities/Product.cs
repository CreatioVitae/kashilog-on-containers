using DomainObject.Kashilog.ConstantValues.Kashi;
using System;

namespace DomainObject.Kashilog.Kashi.Entities; 
public class Product {
    public int ProductId { get; set; }

    public int ProductRevision { get; set; }

    public DateTime ValidBeginDateTime { get; set; }

    public DateTime ValidEndDateTime { get; set; }

    public string ProductName { get; set; } = default!;

    public LargeCategory LargeCategory { get; set; }

    public int MiddleCategory { get; set; }

    public int SmallCategory { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Amount { get; set; }

    public AmountType AmountType { get; set; }

    public string Description { get; set; } = default!;

    public int MakerCompanyId { get; set; }

    public int PublisherCompanyId { get; set; }
}
