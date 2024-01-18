namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        // Aqui crio o metódo construtor da classe "Nokia" que recebe os parametros numero, modelo, imei e memoria
        // que são chamados da classe "Smartphone".
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria) {}
        // Jà aqui é utilizado a palavra chave "override" que sobrescreve os metódos  Ligar, ReceberLigacao
        // e InstalarAplicativo vindos da nossa clase base.
        public override void Ligar()
        {
            Console.WriteLine("Nokia está ligando.");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Nokia está recebendo ligação.");
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo: {nome} no Nokia...");
        }


        
       
     
       
    }
    
    
}