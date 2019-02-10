using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string UserName { get; set; }

        /// <summary>
        /// 회원 아이디
        /// </summary>
        [Required(ErrorMessage = "아이디는 필수입력 값입니다.")]
        public string UserId { get; set; }

        /// <summary>
        /// 회원 비번
        /// </summary>
        [Required(ErrorMessage ="비밀번호는 필수입력 값입니다.")]
        public string UserPw { get; set; }

        /// <summary>
        /// 회원 주소
        /// </summary>
        [Required]
        public string UserAddress { get; set; }

        /// <summary>
        /// 회원 전화번호
        /// </summary>
        [Required(ErrorMessage ="전화번호는 필수입력 값입니다.")]
        [Phone]
        public string UserPhone { get; set; }

        /// <summary>
        /// 회원 이메일
        /// </summary>
        [Required(ErrorMessage ="이메일은 필수입력 값입니다.")]
        [EmailAddress]
        public string UserEmail { get; set; }

        /// <summary>
        /// 회원 생년월일
        /// </summary>
        [Required(ErrorMessage ="생년월일은 필수입력 값입니다.")]
        public string UserBirth { get; set; }

        /// <summary>
        /// 회원 성별 
        /// </summary>
        [Required]
        public string UserGender { get; set; }
        
        /// <summary>
        /// 회원 레벨
        /// </summary>
        [Required]
        public int Level { get; set; }

        /// <summary>
        /// 회원가입날짜
        /// </summary>
        [Required]
        public DateTime UserInsertDate { get; set; }
    }
}
