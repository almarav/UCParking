using System;


namespace UCParking.App.Dominio
{
    public class Administrador : Persona
    {
        public float tarifaAdministrativo {get;set;}
        public string unidad {get;set;}
        public int oficina {get;set;}
    }
}