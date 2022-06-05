using System.ComponentModel.DataAnnotations;

namespace CSIRO.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="User name required")]
        [Display(Name ="User Name")]
        public string regUse { get; set; }

       [StringLength(100,MinimumLength =8,ErrorMessage ="Password must be 8 to 100 character long")]
       [Required(ErrorMessage ="Password Required")]
       [Display(Name ="Password")]
        public string regPassword { get; set; }
        [Display(Name ="Confimr Password")]
        [Required(ErrorMessage ="Please confirm password")]
        [Compare("regPassword" , ErrorMessage ="Password does not match")]
        public string regConfirmPassword { get; set; }
    }
}
