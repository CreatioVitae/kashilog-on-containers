using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
    static readonly ReadOnlyDictionary<LargeCategory, string> LargeCategoryToLargeCategoryDisplayValueDictionary = new(
        new Dictionary<LargeCategory, string>{
            {LargeCategory.TheWestConfectionery, LargeCategoryDisplayValues.TheWestConfectionery },
            {LargeCategory.JapaneseConfectionery, LargeCategoryDisplayValues.JapaneseConfectionery}
        });

    public static string GetDisplayValue(this LargeCategory largeCategory) =>
        LargeCategoryToLargeCategoryDisplayValueDictionary.GetValueOrDefault(largeCategory)
        ?? throw new ArgumentException($"{nameof(largeCategory)}:{largeCategory}に対応するValueが見つかりません。");
}
