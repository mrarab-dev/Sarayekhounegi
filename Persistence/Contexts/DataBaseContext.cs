﻿using Application.Interfaces.Contexts;
using Domain.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class DataBaseContext : DbContext,IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options):base(options) { }
        public DbSet<User> Users { get; set; }
       
        
    }
}
