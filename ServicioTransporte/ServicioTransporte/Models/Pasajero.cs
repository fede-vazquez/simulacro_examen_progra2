using ServicioTransporte.Enums;

namespace ServicioTransporte.Models
{
    public class Pasajero
    {
        public string Nombre { get; private set; }
        public string Direccion {  get; private set; }
        public bool IsMiembro { get; private set; }

        public Pasajero(string nombre, string direccion, bool isMiembro)
        {
            Nombre = nombre;
            Direccion = direccion;
            IsMiembro = isMiembro;
        }

        public Viaje PedirViaje(int CantidadKilometros, TipoVehiculo tipoDeVehiculo)
        {

        }
    }
}
