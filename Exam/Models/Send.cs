using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Send
    {
        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
