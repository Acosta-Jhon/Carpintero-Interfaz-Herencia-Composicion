using Profesiones.Interface;
using System.Collections.Generic;

namespace Profesiones.Implementacion
{
    public class CarpinteroEstandar :ICarpintero
    {
        private string nombre; //Ej : Juan

        private List<string> materialParaClavar; // Ej: clavo,tornillo

        public string Nombre { get => nombre; set => nombre = value; }
        public List<string> MaterialParaClavar { get => materialParaClavar; set => materialParaClavar = value; }

        public string Clavar() 
        {
            return "Estoy clavando";
        }
        public string Serruchar() 
        {
            return "Estoy serruchando";
        }
        public string Medir() 
        {
            return "Estoy midiento con metro";
        }
        public string Lijar()
        {
            return "Estoy lijando";
        }
        public string Lacar() 
        {
            return "Estoy lacando";
        }
        public string Diseñar() 
        {
            return "Estoy diseñando";    
        }
    }
}
