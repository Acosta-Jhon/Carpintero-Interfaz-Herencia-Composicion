using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroModerno : Carpintero,ICarpintero, IEquatable<CarpinteroModerno>
    {
        
        public string Clavar()
        {
            return "Estoy clavando pistola de aire comprimido";
        }
        public string Serruchar()
        {
            return "Estoy serruchando con maquina";
        }
        public string Medir()
        {
            return "Estoy midiento con láser";
        }
        public string Lijar()
        {
            return "Estoy lijando con absorcion";
        }
        public string Lacar()
        {
            return "Estoy lacando con secado instantaneo";
        }
        public string Diseñar()
        {
            return "Estoy diseñando con Autocad";
        }

        public bool Equals([AllowNull] CarpinteroModerno other)
        {
            return this.Id == other.Id;
        }
    }
}
