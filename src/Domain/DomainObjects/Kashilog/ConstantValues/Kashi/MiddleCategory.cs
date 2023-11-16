using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DomainObject.Kashilog.ConstantValues.Kashi;
public enum MiddleCategory {
    Snack = 1,
    Biscuit = 2,
    ChewingGum = 3,
    Chocolate = 4,
    Candy = 5,
    Cake = 6,
    Waffle = 7,
    Beans = 8,
    Rice = 9
}

public readonly struct MiddleCategoryDisplayValues {
    public const string Snack = "スナック類";
    public const string Biscuit = "ビスケット類";
    public const string ChewingGum = "チューインガム類";
    public const string Chocolate = "チョコレート類";
    public const string Candy = "キャンデー類";
    public const string Cake = "ケーキ類";
    public const string Waffle = "ワッフル類";
    public const string Beans = "豆菓子類";
    public const string Rice = "米菓子類";
}

public static class MiddleCategoryExtensions {
    static readonly ReadOnlyDictionary<MiddleCategory, string> MiddleCategoryToMiddleCategoryDisplayValueDictionary = new(
        new Dictionary<MiddleCategory, string>{
            { MiddleCategory.Snack, MiddleCategoryDisplayValues.Snack },
            { MiddleCategory.Biscuit, MiddleCategoryDisplayValues.Biscuit },
            { MiddleCategory.ChewingGum, MiddleCategoryDisplayValues.ChewingGum },
            { MiddleCategory.Chocolate, MiddleCategoryDisplayValues.Chocolate },
            { MiddleCategory.Candy, MiddleCategoryDisplayValues.Candy },
            { MiddleCategory.Cake, MiddleCategoryDisplayValues.Cake },
            { MiddleCategory.Waffle, MiddleCategoryDisplayValues.Waffle },
            { MiddleCategory.Beans, MiddleCategoryDisplayValues.Beans },
            { MiddleCategory.Rice, MiddleCategoryDisplayValues.Rice }
        });

    public static string GetDisplayValue(this MiddleCategory middleCategory) =>
        MiddleCategoryToMiddleCategoryDisplayValueDictionary.GetValueOrDefault(middleCategory)
        ?? throw new ArgumentException($"{nameof(middleCategory)}:{middleCategory}に対応するValueが見つかりません。");
}
