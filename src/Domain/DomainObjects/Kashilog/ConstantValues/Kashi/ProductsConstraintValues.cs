using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainObject.Kashilog.ConstantValues.Kashi;
public static class ProductsConstraintValues {
    public static class ProductName {
        public const int MaximumLength = 200;
        public const int MinimumLength = 1;
        public const string LengthOutOfRangeErrorMessage = $"{nameof(ProductName)}は1-200文字の間で指定してください。";
    }

}
