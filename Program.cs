using DesafioPOO.Models;


Console.WriteLine("Testando dispositivo Nokia");
Nokia lumia = new Nokia("12345", "Lumia 520", "971243876071428", 32);
lumia.Ligar();
lumia.InstalarAplicativo("Discord");
Console.WriteLine();
lumia.ExibirEspecificação();

Console.WriteLine();

Console.WriteLine("Testando dispositivo iphone");
Iphone iphone13Max = new Iphone("67890", "Iphone 13 Pro Max", "013648602687197", 256);
iphone13Max.Ligar();
iphone13Max.InstalarAplicativo("Telegram");
Console.WriteLine();
iphone13Max.ExibirEspecificação();