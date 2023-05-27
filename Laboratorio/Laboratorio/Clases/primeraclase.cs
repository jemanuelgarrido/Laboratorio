public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public int Edad { get; set; }
    public string Cargo { get; set; }

    public Empleado(int id, string nombre, string apellido, int edad, string cargo)
    {
        Id = id;
        Nombre = nombre;
        this.Apellido = apellido;
        Edad = edad;
        Cargo = cargo;
    }
    public override string ToString()
    {
        return $"Id: {Id} Nombre: {Nombre} Apellido: {Apellido} Edad: {Edad} Cargo: {Cargo}";
    }
}

