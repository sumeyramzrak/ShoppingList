using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain.Entities.Main;

namespace Tlp.ShoppingList.Domain.Entities.User
{
    [Table("ShoppingLists", Schema = "User")]
    public class List : EntityBase
    {
        [Required]
        public Guid UserID { get; set; }

        [Required]
        public string ListName { get; set; }

        [Required]
        public Guid CategoryID { get; set; }

        public List<Product> Products { get; set; }

        public string Quantity { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CompletedDate { get; set; }

        public string Note { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public Lookup Lookup { get; set; }
    }
}
