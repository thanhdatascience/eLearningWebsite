using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eLearningWebsite.Model
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Danh mục")]
        public string  Name { get; set; }
    }
}
