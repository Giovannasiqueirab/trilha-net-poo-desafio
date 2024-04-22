using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "484875655", modelo: "Nokia G310", imei: "99525777", memoria: 62);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "227522525", modelo: "Iphone 13 Pro", imei: "777710994", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

// Nokia nokia = new Nokia("99991223108", "11111111", "Nokia G42", "512gb");
// nokia.Ligar();
// nokia.InstalarAplicativo("Facebook");

// Iphone iphone = new Iphone("7770109", "12548763", "Iphone 15 Plus", "512gb");
// iphone.Ligar();
// iphone.InstalarAplicativo("Instagram");