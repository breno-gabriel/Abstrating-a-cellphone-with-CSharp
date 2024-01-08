namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {

        public Iphone(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Acessando Apple store.....");
            Console.WriteLine($"Instalando {nomeApp}");
        }

        
    }
}