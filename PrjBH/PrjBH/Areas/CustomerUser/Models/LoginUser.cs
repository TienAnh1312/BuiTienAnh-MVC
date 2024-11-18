using System.ComponentModel.DataAnnotations;

namespace PrjBH.Areas.CustomerUser.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Mã sinh viên không để trống")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password không để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool Remember { get; set; }
        public int UserID { get; internal set; }
    }
}

