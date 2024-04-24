using Microsoft.AspNetCore.Identity;

namespace CetBlogApp.Models
{
    public class CetUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual List<Blog> Blogs { get; set; }=new List<Blog>();

    }
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? CetUserId { get; set; }
        public virtual CetUser? CetUser { get; set; }

    }
}
