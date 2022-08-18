using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Form_Using_Tah_Helper_pgm.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="name is must")]
        [StringLength(15,MinimumLength =5,ErrorMessage="name must be 5 char long")]
        public string Name { get; set; }



        [Required(ErrorMessage ="Gender is must")] 
        public Gender? Gender { get; set; }


        [Required(ErrorMessage = "Age is must")]
        [Range(10,15)]
        public int? Age { get; set; }



        public string Desg { get; set; }
        
        
        public int salary { get; set; }
        
        
        public string Married { get; set; }
        //gfjfgjfgj

        
        [EmailAddress]
        public string Email {  get; set; }



        [Required]
        //  [RegularExpression(@"(?=.{8,}$)((?=.*\d)|(?=.*\W+))(?|[.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "min 8 char long")]
        [PasswordPropertyText]
        public string Password { get; set; }


        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
    public enum Gender
    {
        Male, Female
    }
}
