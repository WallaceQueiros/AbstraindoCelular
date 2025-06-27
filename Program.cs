using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Modelo 1", imei:"1111111", memoria:64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero:"123478", modelo:"Modelo 2", imei:"10100101", memoria:128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");



