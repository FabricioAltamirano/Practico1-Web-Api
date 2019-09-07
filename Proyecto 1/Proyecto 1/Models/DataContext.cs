


namespace Proyecto_1.Models
    
{
    using System.Data.Entity;
    public class DataContext:DbContext 
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Proyecto_1.Models.Modelo> Modeloes { get; set; }
    }
}