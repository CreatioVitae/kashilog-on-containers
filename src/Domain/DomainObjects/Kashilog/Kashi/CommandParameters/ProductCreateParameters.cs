using DomainObject.Kashilog.ConstantValues.Kashi;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace DomainObject.Kashilog.Kashi.CommandParameters;
public record ProductCreateParameters {
    [Required]
    [CustomValidation(typeof(ProductCreateParameters), nameof(ValidateValidBeginDateTime))]
    public DateTime ValidBeginDateTime { get; init; }

    [Required]
    [CustomValidation(typeof(ProductCreateParameters), nameof(ValidateValidEndDateTime))]
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

    public static ValidationResult? ValidateValidBeginDateTime(DateTime date, ValidationContext context) =>
        ValidateValidDateTimeLocal(date, nameof(ValidBeginDateTime), context);

    public static ValidationResult? ValidateValidEndDateTime(DateTime date, ValidationContext context) =>
        ValidateValidDateTimeLocal(date, nameof(ValidEndDateTime), context);

    static ValidationResult? ValidateValidDateTimeLocal(DateTime date, string inspectionTargetName, ValidationContext context) =>
        date < SqlDateTime.MinValue.Value
            ? new ValidationResult($"{inspectionTargetName}は{SqlDateTime.MinValue.Value}以上の値を設定してください。")
            : ValidationResult.Success;
}
