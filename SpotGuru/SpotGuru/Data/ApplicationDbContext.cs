using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SpotGuru.Models;

namespace SpotGuru.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Monumentos> Monumentos { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slots> Slots { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        public DbSet<Historico> Historico { get; set; }

        }





    }

