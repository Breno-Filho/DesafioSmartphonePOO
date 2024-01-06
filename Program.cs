using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "987654321", modelo: "Lumia 1520", imei: "02468", memoria: 64 );

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "123456789", modelo: "Iphone 15", imei: "13579", memoria: 512 );

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Snapchat");





