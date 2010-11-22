using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace NewInMVC3.Models
{
    public class NewBlogModel
    {
        [Required]
        [SkipRequestValidation]
        public string Subject { get; set; }

        [Required]
        [SkipRequestValidation]
        public string Description { get; set; }
        
        [Required]
        public string Tags { get; set; }
    }
}