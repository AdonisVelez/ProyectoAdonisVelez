class Bateria : Instrumentos
{
    double total;
    int descuento { get; set;}
    public void DatoBateria(int descuento)
    {
        this.descuento = descuento;
    }
    public double CalcularPromocion()
    {
        total = precio*descuento/100;
        return total;
    }
    public void Imprimirbateria()
    {
        Console.WriteLine("Precio con descuento del "+this.descuento+" %: "+CalcularPromocion()+" $");
    }
}