﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProcessingApp.Models;

namespace ProcessingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<ProcessingApp.Models.OwnerModel> OwnerModel { get; set; }
        public DbSet<ProcessingApp.Models.PropertyModel> PropertyModel { get; set; }
        public DbSet<ProcessingApp.Models.MyApplication> MyApplication { get; set; }

    }
}
