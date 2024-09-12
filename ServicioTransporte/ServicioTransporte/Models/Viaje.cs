using ServicioTransporte.Enums;

namespace ServicioTransporte.Models
{
    public class Viaje
    {
        public double TarifaBase { get; private set; }
        public Pasajero Pasajero { get; private set; }
        public Conductor Conductor { get; private set; }
        public int CantidadKilometros { get; private set; }
        public bool IsCompletado { get; private set; }
        public double CostoTotal => Pasajero.IsMiembro ? TarifaBase *= (1 - 0.2) : TarifaBase;
        public EmpresaTaxi EmpresaTaxi { get; private set; }

        public Viaje(double tarifaBase, Pasajero pasajero, int cantidadKilometros, bool isCompletado, EmpresaTaxi empresaTaxi)
        {
            TarifaBase = tarifaBase;
            Pasajero = pasajero;
            CantidadKilometros = cantidadKilometros;
            IsCompletado = isCompletado;
            EmpresaTaxi = empresaTaxi;
        }

        public Conductor ReservarConductor(TipoVehiculo tipoVehiculoSolicitado)
        {
            EmpresaTaxi.Conductores.Find((conductor) => conductor.Transporte.TipoDeVehiculo == tipoVehiculoSolicitado);

            throw new Exception("No se encontro un conductor disponible con ese tipo de vehículo.");
        }
    }
}
