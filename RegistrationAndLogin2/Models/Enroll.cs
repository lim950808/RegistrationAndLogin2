using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RegistrationAndLogin2.Models
{
    public class Enroll
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "FirstName(이름)을 입력해주세요.")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName(성)을 입력해주세요.")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "비밀번호를 입력해주세요.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}$", ErrorMessage = "비빌번호는 최소 8자(대소문자, 숫자, 특수기호 최소 각각 1자)가 필요합니다.")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "비밀번호를 다시 입력해주세요.")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "비밀번호가 일치하지 않습니다. 다시 시도해주세요!")]
        [DataType(DataType.Password)]
        public string Confirmpwd { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }

        public string Gender { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail 형식이 올바르지 않습니다.")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "전화번호를 입력해주세요")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$", ErrorMessage = "전화번호 형식(숫자 8자리)이 올바르지 않습니다.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "보안질문을 입력해주세요.")]
        [Display(Name = "보안질문")]
        public string SecurityAnwser { get; set; }

        public List<Enroll> Enrollsinfo { get; set; }

    }
}