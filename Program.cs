using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Sony Ericson", imei: "99999999", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 6s", imei: "88888888", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Adroid Emulator");