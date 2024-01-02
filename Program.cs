using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("919291919", "Nokia 1", "123132113", 900000);
Iphone iphone1 = new Iphone("9129312931292", "Iphone 1", "123231123", 90000000);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("DIO");

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("DIO");