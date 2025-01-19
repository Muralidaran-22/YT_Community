using Microsoft.EntityFrameworkCore;
using YT_Community.Models;

namespace YT_Community.DBContext
{
    public class YoutubeCommunityContext : DbContext
    {
        public YoutubeCommunityContext(DbContextOptions<YoutubeCommunityContext> options ) : base( options )
        {
        }

        public DbSet<VideoLink> VideoLinks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
