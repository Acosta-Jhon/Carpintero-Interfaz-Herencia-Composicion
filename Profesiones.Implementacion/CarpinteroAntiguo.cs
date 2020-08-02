using System.Collections.Generic;
using Profesiones.Interface;

namespace Profesiones.Implementacion
{
    public class CarpinteroAntiguo :ICarpintero
    {
        //Atributo : se utiliza sustantidos para definirlos.
        //Encapsulacion-desde afuera no se sepa como estan construidos internamente

        public string Nombre { get; set ; }
        public List<string> MaterialParaClavar { get;  set; }

        //Utilizamos verbos para los nombre de los metodos

        //Metodo
        public string Clavar() 
        {
            return $"Mi nombre es : {Nombre} y estoy clavando {MaterialParaClavar[0]}";
        }

        public string Diseñar()
        {
            return "Estoy disenado";
        }

        public string Lacar()
        {
            return "Estoy lacando";
        }

        public string Lijar()
        {
            return "Estoy lijando";
        }

        public string Medir()
        {
            return "Estoy midiendo";
        }

        public string Serruchar()
        {
            return "Estoy serruchando";
        }
        //trar todas las definiciones de la interfaz e impplemntar en la interfaz
    }
}
