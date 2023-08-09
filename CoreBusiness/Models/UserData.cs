using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Models
{
    public  class UserData
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required (ErrorMessage = "Email is required"), ]
        [RegularExpression(Validators.CustomEmail, ErrorMessage = "Please Enter Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number is required"),]
        [RegularExpression(Validators.MobileNumberRegex, ErrorMessage = "Please Enter Valid Phone Number")]
        public string PhoneNumber { get; set; }
        public string CapsuleName { get; set; }
    }
}
