using System.ComponentModel.DataAnnotations;

namespace AspNetBlog.MVC6.ViewModel
{
    public class SignInViewModel
    {
        [Required(ErrorMessage = "User ID is required")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "User Password is required")]
        public string UserPassword { get; set; }
    }
}
