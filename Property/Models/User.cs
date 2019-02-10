using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property.Models
{
    public class User
    {
        /// <summary>
        /// 회원 번호
        /// </summary>
        [Key]
        public int UserNo { get; set; }

        /// <summary>
        /// 회원 이름
        /// </summary>
        [Required]
        [StringLength(300)]
        public string UserName { get; set; }

        /// <summary>
        /// 회원 아이디
        /// </summary>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// 회원 비번
        /// </summary>
        [Required]
        public string UserPw { get; set; }
    }
}
