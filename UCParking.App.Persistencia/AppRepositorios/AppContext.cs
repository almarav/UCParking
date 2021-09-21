using Microsoft.EntityFrameworkCore;
using UCParking.App.Dominio;
     

namespace UCParking.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> persona {get;set;}
        public DbSet<Administrador> administrador {get;set;}
        public DbSet<Transaccion> transaccion {get;set;}
        public DbSet<Vehiculo> vehiculo {get;set;}
        public DbSet<Estado> estado {get;set;}
        public DbSet<Estudiante> estudiante {get;set;}
        public DbSet<Parqueadero> parqueadero {get;set;}
        public DbSet<Profesor> profesor {get;set;}
        public DbSet<Puesto> puesto {get;set;}
        public DbSet<Visitante> visitante {get;set;}
        //public DbSet<TipoVehiculo> tipovehiculo {get;set;}


        //protected override void OnConfiguring(DBcontextOptionsBuilder options)
        //{

        //    if(!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source -(localdb)\\MSSQLLocalDB; Initial Catalog - UCParking");
        //    }

        //}



    }
}