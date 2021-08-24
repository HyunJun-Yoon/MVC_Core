using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetBlog.MVC6.Models
{
    public class Post
    {
        /// <summary>
        /// Post Number
        /// </summary>
        [Key]
        public int PostNumber { get; set; }

        /// <summary>
        /// Post Title
        /// </summary>
        [Required]
        public string PostTitle { get; set; }

        /// <summary>
        /// Post Content
        /// </summary>
        [Required]
        public string PostContent { get; set; }

        /// <summary>
        /// Author Number
        /// </summary>
        [Required]
        public int UserNumber { get; set; }

        [ForeignKey("UserNumber")]
        public virtual User User { get; set; }
    }
}
