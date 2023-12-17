namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected string Modelo { get ; set; }
        protected string Imei { get ; set; }
        protected int Memoria { get ; set; }
        public string Numero { get; set; }
        // FEITO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string imei, string modelo,int memoria)
        {
            Numero = numero;
            Memoria = memoria;
            Modelo = modelo;
            Imei = imei;
            // FEITO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}