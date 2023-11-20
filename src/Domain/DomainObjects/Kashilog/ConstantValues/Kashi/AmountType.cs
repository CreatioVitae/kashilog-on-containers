using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DomainObject.Kashilog.ConstantValues.Kashi;
public enum AmountType {
    Gram = 1,
    Sheet = 2,
    Pack = 3,
    Grain = 4
}

public readonly struct AmountTypeDisplayValues {
    public const string Gram = "g(グラム)";

    public const string Sheet = "枚（まい）";

    public const string Pack = "袋（パック）";

    public const string Grain = "粒（つぶ）";
}

public static class AmountTypeExtensions {
    static readonly ReadOnlyDictionary<AmountType, string> AmountTypeToAmountTypeDisplayValueDictionary = new(
        new Dictionary<AmountType, string>{
            {AmountType.Gram, AmountTypeDisplayValues.Gram },
            {AmountType.Sheet, AmountTypeDisplayValues.Sheet},
            {AmountType.Pack, AmountTypeDisplayValues.Pack},
            {AmountType.Grain, AmountTypeDisplayValues.Grain}
        });

    public static string GetAmountTypeDisplayValue(this AmountType amountType) =>
        AmountTypeToAmountTypeDisplayValueDictionary.GetValueOrDefault(amountType)
        ?? throw new ArgumentException($"{nameof(amountType)}:{amountType}に対応するValueが見つかりません。");
}
