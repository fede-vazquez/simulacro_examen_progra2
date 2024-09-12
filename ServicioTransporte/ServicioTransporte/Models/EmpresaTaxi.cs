namespace ServicioTransporte.Models
{
    public class EmpresaTaxi
    {
        public string Nombre {  get; private set; }
        public List<Conductor> Conductores { get; private set; } = new List<Conductor>();

        public EmpresaTaxi(string nombre, Conductor conductor)
        {
            Nombre = nombre;
            Conductores.Add(conductor);
        }
        public EmpresaTaxi(string nombre, List<Conductor> conductores)
        {
            Nombre = nombre;
            Conductores.AddRange(conductores);
        }
    }
}
