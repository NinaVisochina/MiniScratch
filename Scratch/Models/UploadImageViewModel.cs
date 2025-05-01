using System.ComponentModel.DataAnnotations;

namespace Scratch.Models
{
    public class UploadImageViewModel
    {
        [Required]
        public IFormFile ImageFile { get; set; }

        public string ImagePath { get; set; }
    }

}
