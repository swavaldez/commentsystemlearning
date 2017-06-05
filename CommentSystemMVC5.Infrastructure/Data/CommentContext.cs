using CommentSystemMVC5.Core;

namespace CommentSystemMVC5.Infrastructure.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    

    public partial class CommentContext : DbContext
    {
        public CommentContext()
            : base("name=CommentDbModel")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .Property(e => e.CommentText)
                .IsUnicode(false);
        }
    }
}
