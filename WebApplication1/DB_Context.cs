﻿using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :
            base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}