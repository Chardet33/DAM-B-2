internal class Program
{
    private static void Main(string[] args)
    {
        Silla silla=new Silla(45,new Dimensiones(10,12,5),"Masaf");
    }
}
struct Dimensiones
{
    public readonly int ancho;
    public readonly int alto;
    public readonly int largo;
    public Dimensiones(int ancho,int alto,int largo)
    {
        this.ancho=ancho;
        this.alto=alto;
        this.largo=largo;
    }
    public override string ToString()
    {
        return $"{ancho}x{alto}x{largo}";
    }

}
class Silla : Mueble
{
    public Silla(int peso,Dimensiones dimensiones,string fabricante) : base(peso,dimensiones,fabricante)
    {

    }
    public override string PrecioTransporte()
    {
        return base.PrecioTransporte()+8;
    }
}
class Mesa : Mueble
{
    public Mesa(int peso,Dimensiones dimensiones,string fabricante) : base(peso,dimensiones,fabricante)
    {

    }
    public override string PrecioTransporte()
    {
        return base.PrecioTransporte()+20;
    }
}
class Sofa : Mueble
{
    public Sofa(int peso,Dimensiones dimensiones,string fabricante) : base(peso,dimensiones,fabricante)
    {

    }
    public override string PrecioTransporte()
    {
        return base.PrecioTransporte()+14;
    }
}
class Mueble
{
    int peso;
    Dimensiones dimensiones;
    string fabricante;
    public Mueble(int peso,Dimensiones dimensiones, string fabricante)
    {
        this.peso=peso;
        this.dimensiones=dimensiones;
        this.fabricante=fabricante;
    }
    public virtual string PrecioTransporte(){
        return "El precio del transporte es: "+(peso+dimensiones.ancho+dimensiones.alto+dimensiones.largo);
    }
        
    public void MostrarInfo()
    {
        Console.WriteLine("Peso: "+peso+" Kg \nDimensiones : "+dimensiones.ToString()+" cm \nFabricante: "+fabricante);
    }
}