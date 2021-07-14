using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagment.ViewModels.UserVM
{
    public class LogInVM
    {
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "هذا الحقل مطلوب")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Remember Me")]
        public Boolean RememberMe { get; set; }
    }
}
