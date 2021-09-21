using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    public partial class LTQLdbcontext : DbContext
    {
        public LTQLdbcontext() : base("name=LTQLdbcontext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>() .Property(e => e.Username).IsUnicode(false);
            modelBuilder.Entity<Student>() .Property(e => e.StudentID);
        }
    }
}   