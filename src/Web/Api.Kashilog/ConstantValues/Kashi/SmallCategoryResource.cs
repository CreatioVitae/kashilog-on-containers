using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Api.Kashilog.ConstantValues.Kashi {
    //public enum SmallCategoryEnum {
    //    [Display(Name = "ポテトチップス")]
    //    PotatoChips = 1,

    //    [Display(Name = "プレッツェル")]
    //    Brezel = 2,

    //    [Display(Name = "準チョコレート")]
    //    QuasiChocolate = 3,

    //    [Display(Name = "チョコレート")]
    //    Chocolate = 4,

    //    [Display(Name = "せんべい")]
    //    RiceCracker = 5,

    //    [Display(Name = "キャンデー")]
    //    candy = 6

    //}

    internal static class SmallCategoryResource {
        internal static readonly ReadOnlyDictionary<int, string> DisplayNames = new (
            new Dictionary<int, string>(){
                {1, "ポテトチップス"},
                {2, "プレッツェル"},
                {3, "準チョコレート"},
                {4, "チョコレート"},
                {5, "せんべい"},
                {6, "キャンデー"}
        });
    }
}
