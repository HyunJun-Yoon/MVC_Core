using System.ComponentModel.DataAnnotations;

namespace AspNetBlog.MVC6.Models
{
    public class User
    {
        /// <summary>
        /// User Number
        /// </summary>
        [Key]   //PK 
        public int UserNumber { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [Required(ErrorMessage = "Please Enter User Name")] // Not Null
        public string UserName { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [Required(ErrorMessage = "Please Enter User ID")] // Not Null
        public string UserId { get; set; }


        /// <summary>
        /// User Password
        /// </summary>
        [Required(ErrorMessage = "Please Enter User Password")] // Not Null
        public string UserPassword { get; set; }
    }
}
