using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DomainObject.Kashilog.ConstantValues.Kashi; 
//public enum MiddleCategoryEnum {
//    [Display(Name = "スナック類")]
//    Snack = 1,

//    [Display(Name = "ビスケット類")]
//    Biscuit = 2,

//    [Display(Name = "チューインガム類")]
//    ChewingGum = 3,

//    [Display(Name = "チョコレート類")]
//    Chocolate = 4,

//    [Display(Name = "キャンデー類")]
//    Candy = 5,

//    [Display(Name = "ケーキ類")]
//    Cake = 6,

//    [Display(Name = "ワッフル類")]
//    Waffle = 7,

//    [Display(Name = "豆菓子類")]
//    Beans = 8,

//    [Display(Name = "米菓子類")]
//    Rice = 9
//}

internal static class MiddleCategoryResource {
    internal static readonly ReadOnlyDictionary<int, string> DisplayNames = new(
        new Dictionary<int, string>(){
            {1, "スナック類"},
            {2, "ビスケット類"},
            {3, "チューインガム類"},
            {4, "チョコレート類"},
            {5, "キャンデー類"},
            {6, "ケーキ類"},
            {7, "ワッフル類"},
            {8, "豆菓子類"},
            {9, "米菓子類"}
    });
}
