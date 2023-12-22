using DomainObject.Kashilog.ConstantValues.Kashi;
using System;
using System.ComponentModel.DataAnnotations;

namespace DomainObject.Kashilog.Kashi.CommandParameters;
public record ProductCreateParameters {
    [Required]
    public DateTime ValidBeginDateTime { get; init; }

    [Required]
    public DateTime ValidEndDateTime { get; init; }

    [Required]
    [Length(ProductsConstraintValues.ProductName.MinimumLength, maximumLength: ProductsConstraintValues.ProductName.MaximumLength, ErrorMessage = ProductsConstraintValues.ProductName.LengthOutOfRangeErrorMessage)]
    public required string ProductName { get; init; }

    [Required]
    public LargeCategory LargeCategory { get; init; }

    [Required]
    public MiddleCategory MiddleCategory { get; init; }

    [Required]
    public SmallCategory SmallCategory { get; init; }

    [Required]
    public decimal UnitPrice { get; init; }

    [Required]
    public decimal Amount { get; init; }

    [Required]
    public AmountType AmountType { get; init; }

    [Required]
    public required string Description { get; init; }

    [Required]
    public int MakerCompanyId { get; init; }

    [Required]
    public int PublisherCompanyId { get; init; }
}
