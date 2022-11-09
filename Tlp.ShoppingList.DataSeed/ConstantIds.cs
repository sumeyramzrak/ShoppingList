using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.DataSeed
{
    public static class ConstantIds
    {
        public class User
        {
            public static Guid AdminId = new Guid("63F34CCB-C779-4C82-A1AE-A76C5248BF23");
        }

        public class LookupType
        {
            public static Guid CategoryId = new Guid("C868A137-EFAD-446A-8A62-211574F51241");
        }

        public class Lookup
        {
            public static Guid Market = new Guid("EC534A08-824C-4F56-9E7A-F0E4C235C3E6");
            public static Guid Okul = new Guid("BE7B98C3-DBB4-449B-8EAE-F23E739321EE");
        }
    }
}

