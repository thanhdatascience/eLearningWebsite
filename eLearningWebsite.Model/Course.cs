using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eLearningWebsite.Model
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Khóa Học")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Giá")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Image")]
        public string ImgUrl { get; set; }
        [Required]
        [Display(Name = "CategoryId")]
        public string CategoryId { get; set; }
    }
}
