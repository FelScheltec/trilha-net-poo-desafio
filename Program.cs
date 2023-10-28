using DesafioPOO.Models;
using System;

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new nokia(numero: "123", modelo: "Modelo2", sistemaOperacional: "iOS", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("/N");


Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new iphone(numero: "12322", modelo: "Modelo12", sistemaOperacional: "IOS", memoria: 128 );
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("/N");

e
