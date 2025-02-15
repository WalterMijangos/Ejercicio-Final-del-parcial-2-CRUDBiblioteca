﻿using CRUDBiblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDBiblioteca.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
      
    }
}
