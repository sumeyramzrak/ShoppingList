using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Entities.Main
{
    [Table("SystemParameters", Schema = "Main")]
    public class SystemParameter : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string Key { get; set; }

        [Required]
        [MaxLength(32)]
        public string Value { get; set; }
    }
}
