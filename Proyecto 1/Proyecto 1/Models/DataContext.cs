using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Proyecto_1.Models
{
    public class DataContext:DbContext 
    {
        public DataContext():base("DefaultConnection")
        {

        }

    }
}