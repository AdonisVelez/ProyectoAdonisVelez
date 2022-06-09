class Piano : Instrumentos , IPromocion
{
    double total;
    int descuento { get; set;}
    public void DatoPiano(int descuento)
    {
        this.descuento = descuento;
    }
    public double CalcularPromocion()
    {
        total = precio*descuento/100;
        return total;
    }
    public void ImprimirPiano()
    {
        Console.WriteLine("Precio con descuento del "+this.descuento+" %: "+CalcularPromocion()+" $");
    }
}