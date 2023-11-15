using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Api.Kashilog.ConstantValues.Kashi {
    //public enum LargeCategoryEnum {
    //    [Display(Name = "西洋菓子")]
    //    TheWestConfectionery = 1,

    //    [Display(Name = "和菓子")]
    //    JapaneseConfectionery = 2
    //}

    internal static class LargeCategoryResource {
        internal static readonly ReadOnlyDictionary<int, string> DisplayNames = new (
            new Dictionary<int, string>(){
                {1, "西洋菓子"},
                {2, "和菓子"},
        });
    }
}
