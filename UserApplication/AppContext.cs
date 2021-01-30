using System;
using System.Data.Entity;

namespace UserApplication
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppContext() : base("NewConnect") { }
    }
}
