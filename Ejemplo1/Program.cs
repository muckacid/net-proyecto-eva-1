using Ejemplo1.PModel;

//Declaraciones GLOBALES
Menu menu;
InitComponent();

// Ejecucion
menu.Imprimir();

Console.WriteLine(menu.Imprimir());


Console.WriteLine("+-------------------------+");
Console.WriteLine("|      Menu de libros     |");
Console.WriteLine("+---+---------------------+");
Console.WriteLine("| 1 | Agregar             |");
Console.WriteLine("| 2 | Listar              |");
Console.WriteLine("| 3 | Eliminar            |");
Console.WriteLine("| 4 | Modificar           |");
Console.WriteLine("| 0 | Salir               |");
Console.WriteLine("+---+---------------------+");







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