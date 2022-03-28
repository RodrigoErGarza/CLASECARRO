

using CLASECARRO.Clase;

Carro miCarro = new Carro("Toyota", 2022, "Blanco");

Console.WriteLine("Marca de mi carro: " + miCarro.Marca);
Console.WriteLine("Modelo de mi carro: "+miCarro.Modelo);
miCarro.Encender();
miCarro.Acelerar();
string mensajee = miCarro.Bocinar();
Console.WriteLine(mensajee);
miCarro.Acelerar();
miCarro.Acelerar();
miCarro.Acelerar(3);

string velactual = miCarro.GetVelocidadActual();
Console.WriteLine(velactual);

miCarro.Desacelerar();
miCarro.Desacelerar();
string velreac = miCarro.VelRedAc();
Console.WriteLine(velreac);

miCarro.frenar();
string velgol = miCarro.Velfren();
Console.WriteLine(velgol);

miCarro.Apagar();
miCarro.Encender();
miCarro.Encender();
miCarro.Apagar();
miCarro.Apagar();
miCarro.Encender();
miCarro.Desacelerar();
miCarro.Apagar();
