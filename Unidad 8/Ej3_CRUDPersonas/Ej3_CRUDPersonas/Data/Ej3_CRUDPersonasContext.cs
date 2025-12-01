using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Ej3_CRUDPersonas.Data
{
    public class Ej3_CRUDPersonasContext : DbContext
    {
        public Ej3_CRUDPersonasContext (DbContextOptions<Ej3_CRUDPersonasContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Entities.Persona> Persona { get; set; } = default!;
        public DbSet<Domain.Entities.Departamento> Departamento { get; set; } = default!;
    }
}
