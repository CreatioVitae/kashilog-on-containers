using System;
using System.Collections.Frozen;
using System.Collections.Generic;

namespace DomainObject.Kashilog.ConstantValues.Kashi;
public enum LargeCategory {
    TheWestConfectionery = 1,
    JapaneseConfectionery = 2
}

public readonly struct LargeCategoryDisplayValues {
    public const string TheWestConfectionery = "西洋菓子";

    public const string JapaneseConfectionery = "和菓子";
}

public static class LargeCategoryExtensions {
    static readonly FrozenDictionary<LargeCategory, string> LargeCategoryToLargeCategoryDisplayValueDictionary =
        new Dictionary<LargeCategory, string> {
            {LargeCategory.TheWestConfectionery, LargeCategoryDisplayValues.TheWestConfectionery },
            {LargeCategory.JapaneseConfectionery, LargeCategoryDisplayValues.JapaneseConfectionery}
        }.ToFrozenDictionary();

    public static string GetDisplayValue(this LargeCategory largeCategory) =>
        LargeCategoryToLargeCategoryDisplayValueDictionary.GetValueOrDefault(largeCategory)
        ?? throw new ArgumentException($"{nameof(largeCategory)}:{largeCategory}に対応するValueが見つかりません。");
}
