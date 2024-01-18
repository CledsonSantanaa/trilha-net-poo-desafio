using Microsoft.Win32.SafeHandles;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class IPhone : Smartphone
    {
        // Aqui crio o metódo construtor da classe "Iphone" que recebe os parametros numero, modelo, imei e memoria
        // que são chamados da classe "Smartphone".
        public IPhone(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria) {}
        // Jà aqui é utilizado a palavra chave "override" que sobrescreve os metódos  Ligar, ReceberLigacao
        // e InstalarAplicativo vindos da nossa clase base.
        public override void Ligar()
        {
            Console.WriteLine("Iphone está ligando.");
        }
        public override void ReceberLigacao()
        {
            Console.WriteLine("Iphone está recebendo ligação.");
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no Iphone...");
        }
    }
}