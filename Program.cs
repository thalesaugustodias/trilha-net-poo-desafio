using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "81999999999", modelo: "Nokia 1100 (Lançamento)", imei: "1234567891011", 128);
nokia.Ligar();
nokia.InstalarAplicativo("ZapZap");

System.Console.WriteLine("----------------------------------------");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia (numero: "81999999999", modelo: "Iphone 120 ProMax Total Flex 1.8 turbo", imei: "1234567891012", 1024);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tico&Teco");