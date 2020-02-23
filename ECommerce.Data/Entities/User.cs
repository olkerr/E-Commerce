﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.Data.Entities
{
    public class User : Abstracts.Entity
    {
        [Required, MaxLength(50), MinLength(2)]
        public string Name { get; set; }

        [Required, MaxLength(50), MinLength(2)]
        public string Surname { get; set; }

        [Required, MaxLength(350), MinLength(6)]
        public string Email { get; set; }

        [Required, MaxLength(40), MinLength(40)]
        public string Password { get; set; }

        [Required]
        public bool Admin { get; set; }

    }
}
