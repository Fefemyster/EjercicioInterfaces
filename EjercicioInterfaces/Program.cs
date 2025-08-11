
using EjercicioInterfaces;

Telefono telefono = new Telefono();
telefono.Marca = "Samsung";
telefono.Modelo = "S21Fe";
telefono.Encender();
telefono.MostrarEstado();
telefono.Apagar();
telefono.MostrarEstado();


Laptop laptop = new Laptop();
laptop.Marca = "Lenovo";
laptop.Modelo = "Ideapad";
laptop.NivelBateria = 80;
laptop.Encender();
laptop.MostrarEstado();
laptop.Apagar();
laptop.MostrarEstado();



