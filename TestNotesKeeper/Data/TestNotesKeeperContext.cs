using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestNotesKeeper.Models;

namespace TestNotesKeeper.Data
{
    public class TestNotesKeeperContext : IdentityDbContext<User>
    {
        public TestNotesKeeperContext (DbContextOptions<TestNotesKeeperContext> options)
            : base(options)
        {
        }

        public DbSet<TestNotesKeeper.Models.Note> Note { get; set; }

        public DbSet<TestNotesKeeper.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


        }
    }
}
