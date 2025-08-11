
using EjercicioInterfaces;

Telefono telefono = new Telefono();
telefono.Marca = "Samsung";
telefono.Modelo = "S21Fe";
telefono.Encender();
telefono.MostrarEstado(); // Estado inicial 
telefono.Apagar();
telefono.MostrarEstado(); // Estado final


Laptop laptop = new Laptop();
laptop.Marca = "Lenovo";
laptop.Modelo = "Ideapad";
laptop.NivelBateria = 80;
laptop.Encender();
laptop.MostrarEstado(); // Estado inicial 
laptop.Apagar();
laptop.MostrarEstado(); //Estado final



