using System;
using System.ComponentModel.DataAnnotations;

namespace COMP2084_GameShop.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}