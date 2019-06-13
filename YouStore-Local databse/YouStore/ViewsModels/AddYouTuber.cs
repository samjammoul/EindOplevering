using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouStore.ViewsModels
{
    public class AddYouTuber
    {
        [Required(ErrorMessage = "Vergeet geen Youtuber naam in te vullen.")]
        [Display(Name = "YoutuberName")]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string YoutuberName { get; set; }

        [Required(ErrorMessage = "Vergeet geen Youtuber image in te vullen.")]
        [Display(Name = "YoutuberImage")]
        [MaxLength(30, ErrorMessage = "Name cannot be longer than 20 characters.")]
        public string YoutuberImage { get; set; }
    }
}
