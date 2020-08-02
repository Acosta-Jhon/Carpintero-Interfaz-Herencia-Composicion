using System.Collections.Generic;
        
namespace Profesiones.Entidad
{
    public class Carpintero   //se relacina con los modelos lo squ e va a transpotar infirmacion ---- personas ,auto , celular etc

    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<string> MaterialParaClavar { get; set; }
        public string Apellido { get; set; }
    }
}
