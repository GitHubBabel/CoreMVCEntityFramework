using Microsoft.EntityFrameworkCore;
using CoreMVCEntityFramework.Models;

namespace CoreMVCEntityFramework.Datos
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //INSTANCIAMOS LOS MODELOS
        public  DbSet<UsuarioCLS> Usuario { get; set; }
    }
}
