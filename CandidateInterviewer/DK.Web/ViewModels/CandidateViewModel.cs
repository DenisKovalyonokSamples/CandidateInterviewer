using System.ComponentModel.DataAnnotations;

namespace DK.Web.ViewModels
{
    public class CandidateViewModel
    {
        public int Id { get; set; }

        [Display(Prompt = "Your name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [EmailAddress]
        [Display(Prompt = "Email address")]
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Phone]
        [Display(Prompt = "Phone number")]
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Display(Prompt = "Skype (optional)")]
        public string Skype { get; set; }

        [Required(ErrorMessage = "Please enter your experience or current position")]
        [Display(Prompt = "Experience")]
        public string Description { get; set; }
    }
}
