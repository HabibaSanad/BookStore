﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]        
        public string ISBN { get; set; }
        
        [Required]        
        public string Author { get; set; }
        
        [Required]
        [Range(1,1000)]
        [Display(Name ="List Price")]
        public double ListPrice { get; set; }
        
        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for 1-50")]
        public double Price { get; set; }
        
        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for +50")]
        public double Price50 {  get; set; }
        
        [Required]
        [Range(1, 1000)]
        [Display(Name = "Price for +100")]
        public double Price100 { get; set; }
        [Display(Name ="Category Name")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        
        public Category? Category { get; set; }

        public string? ImageUrl {  get; set; }
    }
}
