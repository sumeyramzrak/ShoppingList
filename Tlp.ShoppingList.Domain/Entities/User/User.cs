﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.Domain.Entities.User
{
    [Table("Users", Schema = "User")]
    public class User : EntityBase
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string VerificationId { get; set; }
    }
}
