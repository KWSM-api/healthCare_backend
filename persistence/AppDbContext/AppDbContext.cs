
using application;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence
{
    public class AppDbContext: IdentityDbContext<User, IdentityRole<int>, int>
    {
           public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<User> Users { get; set; }
    }
}
