using System;


namespace UCParking.App.Dominio
{
    public class Transaccion
    {
        public int id {get;set;}
        public DateTime horaIngreso {get;set;}
        public DateTime horaSalida {get;set;}
        public Vehiculo vehiculo {get;set;}
        public Persona persona {get;set;}
    }
}