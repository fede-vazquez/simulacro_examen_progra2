namespace ServicioTransporte.Models
{
    public class Conductor
    {
        public string Nombre { get; private set; }
        public string Licencia { get; private set; }
        public Transporte Transporte { get; private set; }
        public bool IsDisponible { get; private set; } = true;

        public Conductor(string nombre, string licencia, Transporte transporte)
        {
            Nombre = nombre;
            Licencia = licencia;
            Transporte = transporte;
        }

        public void FinalizarViaje()
        { 
        
        }
    }
}
