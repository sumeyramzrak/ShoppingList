using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Entities.User
{
    [Table("Products", Schema = "User")]
    public class Product : EntityBase
    {
        [Required]
        public string ProductName { get; set; }
    }
}
