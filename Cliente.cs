class Cliente : Usuario
{
    string correo { get; set;}
    int celular { get; set;}
    public void DatoCliente(string correo, int celular)
    {
        this.correo = correo;
        this.celular = celular;
    }
    public void ImprimirCliente()
    {
        Console.WriteLine("Correo: "+this.correo);
        Console.WriteLine("Celular: "+this.celular);

    }
}