using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
 
class Program 

{
    static void Main()
    {
        var nokia = new Nokia("12345", "ModeloN", 123456, 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        var iPhone = new IPhone("67890", "ModeloI", 678901, 32);
        iPhone.Ligar();
        iPhone.ReceberLigacao();
        iPhone.InstalarAplicativo("Instagram");
    }
}