using Profesiones.AccesoDatos;
using Profesiones.Entidad;
using Profesiones.Implementacion;
using Profesiones.Negocio;
using System;

namespace Profesiones.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Constructora MiConstructora = new Constructora();

            MiConstructora.ContratarCarpintero(new CarpinteroModerno()); ;
            MiConstructora.ConstruirMesa();
            var carpinteroModerno = new CarpinteroModerno();
            carpinteroModerno.Id = 1;


            MiConstructora.ContratarCarpintero(new CarpinteroMusical()); ;
            MiConstructora.ConstruirMesa();
            var carpintero = new CarpinteroMusical();
            carpintero.Id = 1;


            MiConstructora.ContratarCarpintero(carpintero); ;
            MiConstructora.ConstruirMesa();

            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            applicationDbContext.Carpinteros.Add(new Carpintero());
            applicationDbContext.SaveChanges();


            Console.ReadKey();
        }
    }
}
