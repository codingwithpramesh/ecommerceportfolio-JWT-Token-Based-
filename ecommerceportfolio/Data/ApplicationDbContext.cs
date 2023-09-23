﻿using ecommerceportfolio.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommerceportfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {

        }

        public DbSet<TokenInfo> TokenInfos { get; set; }


    }
}
