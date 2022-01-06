using System.ComponentModel.DataAnnotations;

namespace Fun_Nutrition.Models
{
    public class Validator
    {
        [Required(ErrorMessage = "Name is required")]
        public string name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "email is required")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        public string email
        {
            get;
            set;
        } = "";

        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
        public string mobile
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Age is required")]
        [Range(typeof(int), "18", "40", ErrorMessage = "Age can only be between 18 and 40")]
        public string age
        {
            get;
            set;
        }
    }
}
