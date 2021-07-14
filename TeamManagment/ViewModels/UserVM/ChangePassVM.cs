using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.ViewModels.UserVM
{
    public class ChangePassVM
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string ConfirmPassword { get; set; }
    }
}
