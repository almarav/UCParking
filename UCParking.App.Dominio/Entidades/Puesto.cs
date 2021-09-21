using System;


namespace UCParking.App.Dominio
{
    public class Puesto
    {
        public int Id {get;set;}
        public int numero {get;set;}
        public Estado estado {get;set;}
        public TipoVehiculo tipoVehiculo {get;set;}
    }
}