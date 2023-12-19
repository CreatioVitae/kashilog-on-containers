using System;
using System.Collections.Frozen;
using System.Collections.Generic;

namespace DomainObject.Kashilog.ConstantValues.Kashi;

public enum SmallCategory {
    PotatoChips = 1,
    Brezel = 2,
    QuasiChocolate = 3,
    Chocolate = 4,
    RiceCracker = 5,
    Candy = 6
}

public readonly struct SmallCategoryDisplayValues {
    public const string PotatoChips = "ポテトチップス";
    public const string Brezel = "プレッツェル";
    public const string QuasiChocolate = "準チョコレート";
    public const string Chocolate = "チョコレート";
    public const string RiceCracker = "せんべい";
    public const string Candy = "キャンデー";
}

public static class SmallCategoryExtensions {
    static readonly FrozenDictionary<SmallCategory, string> SmallCategoryToSmallCategoryDisplayValueDictionary =
        new Dictionary<SmallCategory, string> {
            { SmallCategory.PotatoChips, SmallCategoryDisplayValues.PotatoChips },
            { SmallCategory.Brezel, SmallCategoryDisplayValues.Brezel },
            { SmallCategory.QuasiChocolate, SmallCategoryDisplayValues.QuasiChocolate },
            { SmallCategory.Chocolate, SmallCategoryDisplayValues.Chocolate },
            { SmallCategory.RiceCracker, SmallCategoryDisplayValues.RiceCracker },
            { SmallCategory.Candy, SmallCategoryDisplayValues.Candy }
        }.ToFrozenDictionary();

    public static string GetDisplayValue(this SmallCategory smallCategory) =>
        SmallCategoryToSmallCategoryDisplayValueDictionary.GetValueOrDefault(smallCategory)
        ?? throw new ArgumentException($"{nameof(smallCategory)}:{smallCategory}に対応するValueが見つかりません。");
}
