﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS
{
    public class Context : DbContext
    {
        public DbSet<ENTIDADES.Grupo> Grupos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"DataSource=(localdb)\MsSqlServerdb;InitialCatalog=Seguridad;IntegratedSecurity=true");
        
    }
}
