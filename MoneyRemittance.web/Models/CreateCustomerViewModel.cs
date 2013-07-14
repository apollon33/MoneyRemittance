using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoneyRemittance.web.Models
{
    public class CreateCustomerViewModel
    {
        [ScaffoldColumn(false)]
        public int CustId { get; set; }

        [Display(Name="Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is a required field.")]
        public string LastName { get; set; }

        [Display(Name="First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is a required field.")]
        public string FirstName { get; set; }

        [Display(Name="Home Address")]
        [Required(AllowEmptyStrings=false, ErrorMessage="Home Address is a required field.")]
        [StringLength(250, ErrorMessage = "You have exceeded the maximum text lenght for Home Address")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "City is a required field.")]
        [StringLength(80, ErrorMessage = "You have exceeded the maximum text lenght for City")]
        public string City { get; set; } //Corresponding property in Customer object is CustLocation

        [Display(Name = "Country")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Country is a required field.")]
        public string Country { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your email address.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid email address")]
        public string EmailAdd { get; set; }

        [Display(Name="Confirm Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please confirm your email address.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid confirm email address")]
        public string ConfirmEmailAdd { get; set; }

        [DisplayName("I Agree")]
        [Required(ErrorMessage = "Please check.")]
        public bool Agree { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your password")] 
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage="Minimum of 8 characters of password.", MinimumLength=8)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please confirm your password")] 
        [DataType(DataType.Password)]
        [StringLength(12, ErrorMessage = "Minimum of 8 characters of password.", MinimumLength = 8)]
        public string ConfirmPassword { get; set; }
    }
}