namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
       // Aqui declaro as propriedades dos tipos "string e int" Numero, Modelo, Imei e Memoria.
        public string Numero { get; set; }
        public string Modelo { get; set;}
        public int Imei { get; set; }
        public int Memoria { get; set; }
        // Aqui crio o metódo construtor da classe "Smartphone" que recebe os parametros das propriedades. 
        public Smartphone(string numero, string modelo, int imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        //Aqui declaro os metódos abstratos Ligar, ReceberLigacao e InstalarAplicativo.
        //Os metódos Ligar e ReceberLigacao não recebem parâmetros e será implementados nas classes.
        //Já o metódo InstalarAplicativo recebe o parâmetro nome que será o nome do aplicativo e este 
        //por sua vez também deve ser implemetado nas classes.
        public abstract void Ligar();

        public abstract void ReceberLigacao();

        public abstract void InstalarAplicativo(string nome);
    }
}