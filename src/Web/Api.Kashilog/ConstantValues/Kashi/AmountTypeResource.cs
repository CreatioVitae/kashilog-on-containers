using System.Collections.ObjectModel;

namespace Api.Kashilog.ConstantValues.Kashi {
    //internal enum AmountTypeResource {
    //    [Display(Name = "g(グラム)")]
    //    Gram = 1,

    //    [Display(Name = "枚（まい）")]
    //    Sheet = 2,

    //    [Display(Name = "袋（パック）")]
    //    Pack = 3,

    //    [Display(Name = "粒（つぶ）")]
    //    Grain = 4
    //}

    internal static class AmountTypeResource {
        internal static readonly ReadOnlyDictionary<int, string> DisplayNames = new(
            new Dictionary<int, string>(){
                {1, "g(グラム)"},
                {2, "枚（まい）"},
                {3, "袋（パック）"},
                {4, "粒（つぶ）"}
        });
    }
}
