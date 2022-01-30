using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PROGRAMA.Models
{
    public class Contexto : System.Data.Entity.DbContext
    {
        //construtor
        public System.Data.Entity.DbSet<Programa> Programa { get; set; }
        public System.Data.Entity.DbSet<ObjetivoPrograma> ObjetivoProgramas { get; set; }

        public System.Data.Entity.DbSet<IndicadorPrograma> IndicadorProgramas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
