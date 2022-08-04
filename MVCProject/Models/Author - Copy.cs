﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
    }
}
