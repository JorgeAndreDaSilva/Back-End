using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _18_CRUD_BD.Models;

    public class AppDbContex : DbContext
    {
        public AppDbContex (DbContextOptions<AppDbContex> options)
            : base(options)
        {
        }

        public DbSet<_18_CRUD_BD.Models.Jogo> Jogo { get; set; } = default!;
    }
