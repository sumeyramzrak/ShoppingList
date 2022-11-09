using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Entities.Main
{
    [Table("LookupTypes", Schema = "Main")]
    public class LookupType : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
