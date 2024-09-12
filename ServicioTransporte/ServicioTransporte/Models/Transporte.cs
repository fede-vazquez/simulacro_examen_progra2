using ServicioTransporte.Enums;

namespace ServicioTransporte.Models
{
    public class Transporte
    {
        public TipoVehiculo TipoDeVehiculo { get; private set; }
        public string Patente { get; private set; }

        public Transporte(TipoVehiculo tipoDeVehiculo, string patente)
        {
            TipoDeVehiculo = tipoDeVehiculo;
            Patente = patente;
        }
    }
}
