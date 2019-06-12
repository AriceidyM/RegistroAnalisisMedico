using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using RegistroAnalisisMedico.Entidades;
using System.Threading.Tasks;

namespace RegistroAnalisisMedico.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Analisis> Analisis { get; set; }

        public DbSet<TiposAnalisis> TipoAnalis { get; set; }


        public Contexto() : base("ConStr")
        { }
    }
}
