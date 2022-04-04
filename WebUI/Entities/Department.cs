﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Entities
{
    [Table("Department")]
    public class Department
    {
        [Key] 

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
