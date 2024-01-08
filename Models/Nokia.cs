namespace DesafioPOO.Models
{
    public class Nokia: Smartphone
    {

        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando a Microsoft Store.............");
            Console.WriteLine($"Instalando {nomeApp}");
        }

    }
}