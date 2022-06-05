using System.ComponentModel.DataAnnotations;

namespace CSIRO.Models
{
    public class UserModel
    {
       [Key]
       [Range(100,9999)]
       
        private int userId { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First name required")]
        public string userFName { get; set; }

        [Display(Name ="Last Name")]
        [Required(ErrorMessage ="Last Name Required")]
        public string userLName { get; set; }

        [Display(Name ="Address")]
        [Required(ErrorMessage ="Address Required")]
        public string userAddress { get; set; }

        [Display(Name = "University")]
        [Required(ErrorMessage = "University Field Required")]
        public string userUni { get; set; }

        [Display(Name = "Course")]
        
        public string userCourse { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone Number Required")]
        public string userContact { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Required")]
        public string userEmail { get; set; }

        [Display(Name ="Load CV (Optional)")]
        [DataType(DataType.Upload)]
        public string userCV { get; set; }

        [Display(Name ="Coverletter")]
        [DataType(DataType.MultilineText)]
        public string userCL { get; set; }


    }
}
