using System;


namespace UCParking.App.Dominio
{
    public class Visitante : Persona
    {
        public float tarifaVisitante {get;set;}
        public string actividad {get;set;}
        //public Persona Autoriza {get;set;}
        public string autoriza {get;set;}
    }
}