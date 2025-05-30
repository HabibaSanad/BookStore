﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "The Name Must be Between 3 and 30")]
        [MinLength(3, ErrorMessage = "The Name Must be Between 3 and 30")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
