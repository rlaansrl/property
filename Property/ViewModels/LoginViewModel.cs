using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="아이디를 입력해 주세요.")]
        public string UserId { get; set; }

        [Required(ErrorMessage ="비밀번호를 입력해 주세요.")]
        public string UserPw { get; set; }
    }
}
