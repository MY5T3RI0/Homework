using System.Data.Entity;

namespace MyDB
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("DbConnection")
        { 
        
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
