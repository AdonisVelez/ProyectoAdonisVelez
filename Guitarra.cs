class Guitarra : Instrumentos , IPromocion
{
    double total;
    int descuento { get; set;}
    public void DatoGuitarra(int descuento)
    {
        this.descuento = descuento;
    }
    public double CalcularPromocion()
    {
        total = precio*descuento/100;
        return total;
    }
    public void ImprimirGuitarra()
    {
        Console.WriteLine("Precio con descuento del "+this.descuento+" %: "+CalcularPromocion()+" $");
    }
}