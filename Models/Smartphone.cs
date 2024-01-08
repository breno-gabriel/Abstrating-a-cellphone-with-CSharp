namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Memory { get; set; }

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirEspecificação() {

            Console.WriteLine($"Espeficicações do aparelho: \n Modelo: {Model} \n Armazenamento: {Memory} GB \n Número: {Number}");

        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}