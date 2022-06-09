using System;
namespace ProyectoAdonis
{
    class Program
    {
        public static void Main(String[] args)
        { 

            Vendedor vendedor1 = new Vendedor();
            vendedor1.DatoUsuario("Carlos Javier","Anchundia Mero","Portoviejo",1316452457);
            vendedor1.DatoVendedor(30,15,"Guitarra");
                   
            Vendedor vendedor2 = new Vendedor();
            vendedor2.DatoUsuario("Romina Elizabeth","Vera Carranza","Manta",1316452460);
            vendedor2.DatoVendedor(32,20,"Piano");
            
            Cliente cliente = new Cliente();
            cliente.DatoUsuario("Adonis Agustin","Velez Cedeño","Jaramijo",1316765427);
            cliente.DatoCliente("aavc.1316765427@gmail.com", 0960498554);
                  
            Guitarra guitarra1 = new Guitarra();
            guitarra1.Pedirdatos("Squier","Squier SQ CV 60s Tele",523.97,"ThinLine Mn natural");
            
            Guitarra guitarra2 = new Guitarra();
            guitarra2.Pedirdatos("Gibson","Mcrs4swlwb J-45",726.78,"Negro");
            
            Guitarra guitarra3 = new Guitarra();
            guitarra3.Pedirdatos("Fender","Player Jaguar ",705.80,"Rojo Metalico");
            guitarra3.DatoGuitarra(15);
           
            Guitarra guitarra4 = new Guitarra();
            guitarra4.Pedirdatos("Ephiphone","Les Paul Classic",700.80,"Caoba");
            guitarra4.DatoGuitarra(20);

            Bajo bajo1 = new Bajo();
            bajo1.Pedirdatos("Fender","Fender Player Bass",867.93,"Mn 3Ts");

            Bajo bajo2 = new Bajo();
            bajo2.Pedirdatos("Epiphone","epiphone Viola Bass",671.69,"Sunburts Ch Hdwe");
            
            Bajo bajo3 = new Bajo();
            bajo3.Pedirdatos("Squier","Squier Classic Vibe 70s",889.86,"Maple Fingerboard, Natural");
            bajo3.DatoBajo(20);
            
            Bajo bajo4 = new Bajo();
            bajo4.Pedirdatos("Gretsch","EMTC Jr Jet Bass",500.50,"BLK");

            Bateria bateria1 = new Bateria();
            bateria1.Pedirdatos("Mapex","Armony Series Ultramarine",1604.01,"Maple");

            Bateria bateria2 = new Bateria();
            bateria2.Pedirdatos("Dixon","Wine Red Spark Series",579.74,"Wine Red");

            Bateria bateria3 = new Bateria();
            bateria3.Pedirdatos("Roland","TD-07KV",500.82,"Azul");
            bateria3.DatoBateria(15);

            Bateria bateria4 = new Bateria();
            bateria4.Pedirdatos("Dixon","Champagne Spark series",764.91,"Plomo");
            bateria4.DatoBateria(15);

            Piano piano1 = new Piano();
            piano1.Pedirdatos("Roland","Juno-Ds76",2121.96,"Negro");
 
            Piano piano2 = new Piano();
            piano2.Pedirdatos("Alesis","Harmony 32",78.12,"Rojo");

            Piano piano3 = new Piano();
            piano3.Pedirdatos("Roland","E-X20A",500.50,"Negro");
            piano3.DatoPiano(10);

            Piano piano4 = new Piano();
            piano4.Pedirdatos("Alesis","Recital Pro",700.90,"Azul");
            piano4.DatoPiano(10);

            string input= "";
                while(input!="0")
                    {
                    Console.WriteLine("Bienvenido en que te puedo ayudar");
                    Console.WriteLine("1- Usuario");
                    Console.WriteLine("2- Producto");
                    Console.WriteLine("3- Buscar");
                    Console.WriteLine("4- Ofertas");
                    Console.WriteLine("0- Salir");
                    input = Console.ReadLine();
                
                    switch (input)
                    {
                    case "1":
                    Console.Clear();
                    Console.WriteLine("Usuario");
                    Console.WriteLine("");
                    Console.WriteLine("1- Datos del Cliente");
                    Console.WriteLine("2- Datos del Vendedor");
                    Console.WriteLine("0- Salir");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                        Console.Clear();
                        Console.WriteLine("Datos del Cliente");
                        cliente.ImprimirUsuario();
                        cliente.ImprimirCliente(); 
                        break;

                        case "2":
                        Console.Clear();
                        Console.WriteLine("Datos del Vendedor");
                        vendedor1.ImprimirUsuario();
                        vendedor1.ImprimirVendedor();
                        vendedor2.ImprimirUsuario();
                        vendedor2.ImprimirVendedor();
                        break;

                        case "0":
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR SU VISITA");
                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Ingreso un caracter no valido");
                        Console.WriteLine("Vuelva a intentarlo");
                        break;
                    }
                    
                    break;
                    
                    case "2":
                    Console.Clear();
                    Console.WriteLine("Productos");
                    Console.WriteLine("1- Guitarras");
                    Console.WriteLine("2- Bajos");
                    Console.WriteLine("3- Baterias");
                    Console.WriteLine("4- Piano");
                    Console.WriteLine("0- Salir");
                    input = Console.ReadLine();  

                    switch (input)
                    {
                        case "1":
                        Console.Clear();
                        Console.WriteLine("Guitarras");
                        guitarra1.Imprimirdatos();
                        guitarra2.Imprimirdatos();
                        break;

                        case "2":
                        Console.Clear();
                        Console.WriteLine("Bajos");
                        bajo1.Imprimirdatos();
                        bajo2.Imprimirdatos();
                        break;

                        case "3":
                        Console.Clear();
                        Console.WriteLine("Bateria");
                        bateria1.Imprimirdatos();
                        bateria2.Imprimirdatos();
                        break;

                        case "4":
                        Console.Clear();
                        Console.WriteLine("Piano");
                        piano1.Imprimirdatos();
                        piano2.Imprimirdatos();
                        break;

                        case "0":
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR SU VISITA");
                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Ingreso un caracter no valido");
                        Console.WriteLine("Vuelva a intentarlo");
                        break;
                    }
                    break;

                    case"3":
                    Console.Clear();
                    Console.WriteLine("Buscar");
                    Console.WriteLine("Instrumento a buscar");
                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "guitarra":
                        Console.Clear();
                        Console.WriteLine("Guitarra");
                        guitarra1.Imprimirdatos();
                        guitarra2.Imprimirdatos();
                        guitarra3.Imprimirdatos();
                        guitarra3.ImprimirGuitarra();
                        guitarra4.Imprimirdatos();
                        guitarra4.ImprimirGuitarra();
                        break;
                        case "bajo":
                        Console.Clear();
                        Console.WriteLine("Bajo");
                        bajo1.Imprimirdatos();
                        bajo2.Imprimirdatos();
                        bajo3.Imprimirdatos();
                        bajo3.ImprimirBajo();
                        bajo4.Imprimirdatos();
                        bajo4.ImprimirBajo();
                        break;

                        case "bateria":
                        Console.Clear();
                        Console.WriteLine("Bateria");
                        bateria1.Imprimirdatos();
                        bateria2.Imprimirdatos();
                        bateria3.Imprimirdatos();
                        bateria3.Imprimirbateria();
                        bateria4.Imprimirdatos();
                        bateria4.Imprimirbateria();
                        break;

                        case "piano":
                        Console.Clear();
                        Console.WriteLine("Piano");
                        piano1.Imprimirdatos();
                        piano2.Imprimirdatos();
                        piano3.Imprimirdatos();
                        piano3.ImprimirPiano();
                        piano1.Imprimirdatos();
                        piano4.ImprimirPiano();
                        break;

                        default:
                        Console.Clear();
                        Console.WriteLine("Ingreso un caracter no valido");
                        Console.WriteLine("Vuelva a intentarlo");
                        break;
                    }
                    break;

                    case "4":
                    Console.Clear();
                    Console.WriteLine("Ofertas");
                    Console.WriteLine("1- Guitarras");
                    Console.WriteLine("2- Bajos");
                    Console.WriteLine("3- Baterias");
                    Console.WriteLine("4- Piano");
                    Console.WriteLine("0- Salir");
                    input = Console.ReadLine();               

                    switch (input)
                    {
                        case "1":
                        Console.Clear();
                        Console.WriteLine("Guitarras");
                        guitarra3.Imprimirdatos();
                        guitarra3.ImprimirGuitarra();
                        guitarra4.Imprimirdatos();
                        guitarra4.ImprimirGuitarra();
                        break;

                        case "2":
                        Console.Clear();
                        Console.WriteLine("Bajos");
                        bajo3.Imprimirdatos();
                        bajo3.ImprimirBajo();           
                        bajo4.Imprimirdatos();
                        bajo4.ImprimirBajo();
                        break;

                        case "3":
                        Console.Clear();
                        Console.WriteLine("Bateria");
                        bateria3.Imprimirdatos();
                        bateria3.Imprimirbateria();
                        bateria4.Imprimirdatos();
                        bateria4.Imprimirbateria();
                        break;

                        case "4":
                        Console.Clear();
                        Console.WriteLine("Piano");
                        piano3.Imprimirdatos();
                        piano3.ImprimirPiano();
                        piano1.Imprimirdatos();
                        piano4.ImprimirPiano();
                        break;
                        
                        case "0":
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR SU VISITA");
                        break;
                        
                        default:
                        Console.Clear();
                        Console.WriteLine("Ingreso un caracter no valido");
                        Console.WriteLine("Vuelva a intentarlo");
                        break;
                    }
                    break;

                    case "0":
                    Console.Clear();
                    Console.WriteLine("GRACIAS POR SU VISITA");
                    break;
                    default:
                    Console.Clear();
                    Console.WriteLine("Ingreso un caracter no valido");
                    Console.WriteLine("Vuelva a intentarlo");
                    break;

                }
            Console.ReadKey();
            } 
        }
    } 
}