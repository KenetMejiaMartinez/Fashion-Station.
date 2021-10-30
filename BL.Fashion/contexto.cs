using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Fashion
{
    public class contexto: DbContext 
    {

        public contexto():base("Mercaderia")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); //agrega datos de inicio a la base de datos despues de eliminarla
        }

        public DbSet<Producto> Productos { get; set;}
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get;  set; }
    }
}
