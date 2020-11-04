﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_2__26047179.Models;

namespace Project_2__26047179.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<JobSpecs> JobSpecs { get; set; }
        public DbSet<JobInfo> JobInfo { get; set; }
        public DbSet<Personal> Personal { get; set; }

    }
}
