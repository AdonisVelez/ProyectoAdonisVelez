class Instrumentos
{
    public string marca { get; set;}
    public string modelo { get; set;}
    public double precio { get; set;}
    public string color { get; set; }
    public void Pedirdatos(string marca, string modelo, double precio, string color)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.precio = precio;
        this.color = color;

    }
    public void Imprimirdatos()
    {
        Console.WriteLine();
        Console.WriteLine("Marca: "+this.marca);
        Console.WriteLine("Modelo: "+this.modelo);
        Console.WriteLine("Color: "+this.color);
        Console.WriteLine("Precio: "+this.precio+" $");
    }
}