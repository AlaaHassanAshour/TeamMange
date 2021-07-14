using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.ViewModels.UserVM
{
    public class ForegetPassword
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
