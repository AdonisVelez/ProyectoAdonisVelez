class Usuario
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    string ciudad { get; set;}
    public int id { get; set; }

    public void DatoUsuario(string nombre, string apellido, string ciudad, int id)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.ciudad = ciudad;
        this.id = id;
    }
    public void ImprimirUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Ciudad: "+this.ciudad);
        Console.WriteLine("Identificación: "+this.id);
    }
}