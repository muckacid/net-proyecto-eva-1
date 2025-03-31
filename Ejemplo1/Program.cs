// REFERENCIAS
using Ejemplo1.PModel;

//Declaraciones GLOBALES
Menu menu;
InitComponent();

// Ejecucion

bool run = true;
while (run)
{
    Console.WriteLine(menu.Imprimir());
    Console.Write("Ingrese una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine($"->{opcion}");
    switch (opcion)
    {
        case 0:
            Console.WriteLine("Saliendo con tu mamita...");
            run = false;
            break;
        case 1:
            Console.WriteLine("Agregar");
            break;
        default:
            Console.WriteLine("Opcion ioncorrecta");
            break;
    }
}



// Configuracion del software
void InitComponent()
{
    //Primero definir las opciones de mi menu
    menu = new Menu();
    menu.Opciones.Add(new Item(1, "Agregar"));
    menu.Opciones.Add(new Item(2, "Eliminar"));
    menu.Opciones.Add(new Item(3, "Modificar"));
    menu.Opciones.Add(new Item(4, "Listar"));
    menu.Opciones.Add(new Item(0, "Salir"));
}

