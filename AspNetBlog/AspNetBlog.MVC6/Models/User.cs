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
        [Required] // Not Null
        public string UserName { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [Required] // Not Null
        public string UserId { get; set; }


        /// <summary>
        /// User Password
        /// </summary>
        [Required] // Not Null
        public string UserPassword { get; set; }
    }
}
