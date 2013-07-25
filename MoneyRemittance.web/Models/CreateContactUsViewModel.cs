using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoneyRemittance.web.Models
{
    public class CreateContactUsViewModel
    {
        [ScaffoldColumn(false)]
        public int ConfigDetailNo { get; set; }
        [ScaffoldColumn(false)]
        public string ConfigDetailName { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is a required field.")]
        public string FName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is a required field.")]
        public string LName { get; set; }

        [Display(Name = "Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your email address.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Display(Name = "Select a Topic")]
        public string Topic { get; set; }

        [Display(Name = "Provide details of issue here")]
        public string Details { get; set; }

        //Contains the list of topics
        //public SelectTopic Inquiries { get; set; }
    }
}