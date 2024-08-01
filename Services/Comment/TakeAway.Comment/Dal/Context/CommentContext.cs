using Microsoft.EntityFrameworkCore;
using TakeAway.Comment.Dal.Entities;

namespace TakeAway.Comment.Dal.Context
{
    public class CommentContext : DbContext
    {
        public CommentContext(DbContextOptions<CommentContext> options):base(options)
        {
         
        }
        public DbSet<UserComment> UserComments { get; set; }
    }
}
