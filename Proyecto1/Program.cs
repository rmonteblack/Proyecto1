using System;
using System.ComponentModel.Design;
using Proyecto1;

static void Mains (string[]args)
{
    Estacionamiento estacionamiento = new Estacionamiento ();
    Menu();
}

static void Menu ()
{
    while (true)
    {
        Console.WriteLine("Bievenido al parque landivar");
        Console.WriteLine("Por favor selecccione una opción para continuar");
    }
}