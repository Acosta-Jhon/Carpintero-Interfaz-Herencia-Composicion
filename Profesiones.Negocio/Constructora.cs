using Profesiones.Entidad;
using Profesiones.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Profesiones.Negocio
{
    public class Constructora  //logica purita calculo matematicos
    {
        //Propiedades
        public ICarpintero Carpintero { get; set; }

        public string ContratarCarpintero(ICarpintero carpintero) 
        {
            Carpintero = carpintero;
            return "Conrate un carpintero"; 
        }

        public string ConstruirMesa() 
        {
            return Carpintero.Diseñar() + "mesa" +
             Carpintero.Medir() + "mesa" +
             Carpintero.Serruchar() + "mesa" +
             Carpintero.Lijar() + "mesa" +
             Carpintero.Clavar() + "mesa" +
             Carpintero.Lacar();
        }

        public string ContratarCarpintero()
        {

            return "Contrate un carpintero";
        }

    }
    // 1. Veo que es lo que se esta repitiendo y lo saco aparte y no que no lo dejo 
}
