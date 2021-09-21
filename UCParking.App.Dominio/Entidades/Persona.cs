using System;

namespace UCParking.App.Dominio
{
 
    public class Persona
    {
        // Identificador único de cada persona
        public int id {get;set;}
        public string nombre {get;set;}
        public string apellidos {get;set;}
        public int identificacion {get;set;}
        public string correoElectronico {get;set;}
        public string telefono {get;set;}
        public string condicionEspecial {get;set;}
        public Vehiculo vehiculo1 {get;set;}
        public Vehiculo vehiculo2 {get;set;}
    }
}