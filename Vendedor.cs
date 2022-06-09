class Vendedor : Usuario
{
    int añosvendedor { get; set;}
    int añomusico { get; set;}
    string favoritoinst { get; set; }
    public void DatoVendedor(int añomusico, int añosvendedor, string favoritoinst)
    {
        this.añomusico = añomusico;
        this.añosvendedor = añosvendedor;
        this.favoritoinst = favoritoinst;
    }
    public void ImprimirVendedor()
    {
        Console.WriteLine("Años como musico: "+this.añomusico+" años");
        Console.WriteLine("Años como vendedor de instrumentos: "+this.añosvendedor+" años");
        Console.WriteLine("Instrumento favorito: "+this.favoritoinst);
    }
}