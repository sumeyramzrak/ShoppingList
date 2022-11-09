using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Common
{
    public class CurrentUserClaims : IClaims
    {
        public CurrentUserClaims()
        {
            CurrentUser = new CurrentUser();
        }
        public bool IsAuthenticated { get; set; }
        public CurrentUser CurrentUser { get; set; }
    }
}
