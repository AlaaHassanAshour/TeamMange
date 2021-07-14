using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.ViewModels.UserVM
{
    public class RegisterVMD
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="كلمة المرور غير متطابقة")]
        public string ConfirmPassword { get; set; }
    }
}
