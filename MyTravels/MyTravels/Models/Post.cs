using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTravels.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        public DateTime UploadDate { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "From")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "To")]
        public DateTime EndDate { get; set; }

        public string Description { get; set; }
    }
}
