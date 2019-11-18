using System.Data.Entity;
using TwitterClone.App_Code;
using TwitterClone.Models;

namespace TwitterClone.ModelsApp_Code
{
    public partial class TwitterDbContext : DbContext
    {
        public TwitterDbContext(): base("TweeterConnectionString")
        {

        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<TWEET> TWEETs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.fullName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Following)
                .WithMany(e => e.People)
                .Map(m => m.ToTable("FOLLOWING").MapLeftKey("following_id").MapRightKey("user_id"));

            modelBuilder.Entity<TWEET>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<TWEET>()
                .Property(e => e.message)
                .IsUnicode(false);
        }
    }
}
