using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData
{
    public class PubContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=PubIntroDatabase;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True");
                //"Server=localhost;Database=PubIntroDatabase;User Id=sa;Password=P@ssw0rd;"
        }
    }
}
