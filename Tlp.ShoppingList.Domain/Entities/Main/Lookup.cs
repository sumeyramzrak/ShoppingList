using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Entities.Main
{
    [Table("Lookups", Schema = "Main")]
    public class Lookup : EntityBase
    {
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }
        [Required]
        public Guid TypeId { get; set; }
        public Guid? ParentId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public LookupType Type { get; set; }

        [ForeignKey(nameof(ParentId))]
        public Lookup Parent { get; set; }
    }
}
