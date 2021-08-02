using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VsCodeUserApi.Models;

namespace VsCodeUserApi.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
    }
}
