using System;


namespace UCParking.App.Dominio


{
    public class Parqueadero
    {
        public int id {get;set;}
        public string direccion {get;set;}
        public string horario {get;set;}
        public int picoPlaca {get;set;}
        public int numeroPuesto {get;set;}
        public System.Collections.Generic.List<Puesto> puesto {get;set;}
        public System.Collections.Generic.List<Persona> persona {get;set;}
        public System.Collections.Generic.List<Transaccion> transaccion {get;set;}
    }



}