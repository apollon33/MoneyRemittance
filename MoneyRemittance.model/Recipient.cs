using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MoneyRemittance.model
{
    public class Recipient
    {
        [ScaffoldColumn(false)]
        public virtual int RecipientId { get; set; }

        [DisplayName("Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is a required field.")]  
        [StringLength(50)]
        public virtual string RecipientLName { get; set; }

        [DisplayName("First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is a required field.")]
        [StringLength(80)]
        public virtual string RecipientFName { get; set; }

        [DisplayName("Middle Initial")]
        [StringLength(5)]
        public virtual string RecipientMI { get; set; }

        [DisplayName("Email Address")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your email address.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(80)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email address")]
        public virtual string RecipientEmailAdd { get; set; }

        [DisplayName("Home Address")]
        [StringLength(250, ErrorMessage = "You have exceeded the maximum text lenght for Home Address")]
        public virtual string RecipientAddress { get; set; }

        [DisplayName("Country")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Country is a required field.")]
        [StringLength(50)]
        public virtual string RecipientCountry { get; set; }

        [DisplayName("Postal Code")]
        [StringLength(12)]
        public virtual string RecipientPostalCode { get; set; }

        [DisplayName("City")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "City is a required field.")]
        [StringLength(80)]
        public virtual string RecipientCity { get; set; }

        [DisplayName("Mobile/Contact No.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact number is a required field.")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(35)]
        public virtual string RecipientMobileNum { get; set; }

        [DisplayName("Gender")]
        [StringLength(20)]
        public virtual string RecipientGender { get; set; }

        public virtual int CustomerId { get; set; }
    }
}
