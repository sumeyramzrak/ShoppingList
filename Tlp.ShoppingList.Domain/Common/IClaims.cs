using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Common
{
    public interface IClaims //HttpContexte dolaşan kullanıcı
    {
        bool IsAuthenticated { get; set; }
        public CurrentUser CurrentUser { get; set; }
    }
}
