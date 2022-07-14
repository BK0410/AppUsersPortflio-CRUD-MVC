using System.ComponentModel.DataAnnotations;

namespace AppUsersPortflio.Models
{
    public class AppUser
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Contact { get; set; }

    }
}
