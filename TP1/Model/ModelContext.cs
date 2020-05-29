using Model.classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=ConnexionStringTP1")
        {
            Database.SetInitializer<ModelContext>(new DropCreateDatabaseIfModelChanges<ModelContext>());
        }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Eleve> Eleves { get; set; }
        public DbSet<Note> Notes{ get; set; }
        public DbSet<Absence> Absences { get; set; }
    }
}
