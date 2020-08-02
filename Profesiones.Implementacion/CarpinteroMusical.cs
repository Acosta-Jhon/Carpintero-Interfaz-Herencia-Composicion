using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Profesiones.Implementacion
{
    public class CarpinteroMusical : ICarpintero,IEquatable<CarpinteroMusical>
    {
        //Composicion   <==============================================================
        private Carpintero  carpintero = new Carpintero(); // <=

        public int Id { get => carpintero.Id; set => carpintero.Id = value; }

        public string Clavar()
        {
            return "Estoy clavando, escuchando trap";
        }

        public string Diseñar()
        {
            return "estoy diseñando y cantando";
        }

        public bool Equals([AllowNull] CarpinteroMusical other)
        {
            return this.Id == other.Id;
        }

        public string Lacar()
        {
            return "estoy lacando y bailando";
        }

        public string Lijar()
        {
            return "estoy lijando e improvisando"; ;
        }

        public string Medir()
        {
            return "estoy meidiendo y fumando";
        }

        public string Serruchar()
        {
            return "estoy serruchando y trapeando";
        }
    }
}
