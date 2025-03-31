// REFERENCIAS
using Ejemplo1.Model;
using Ejemplo1.PModel;

//Declaraciones GLOBALES
Menu menu;
List<Libro> listaDeLibros;
InitComponent();

void listarLibros()
{
    Console.WriteLine("-------Lista de Libros------");
    Console.WriteLine("| ID | Titulo | Autor | Genero | ISBN |");

    foreach (Libro libro in listaDeLibros)
    {
        Console.WriteLine(libro);
    }

    Console.WriteLine("---------------------------------");
}




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
        case 2:
            Console.WriteLine("Eliminar");
            break;
        case 3:
            Console.WriteLine("Modificar");
            listarLibros();
            Console.WriteLine("Ingrese el id del libro que desea modificar: ");
            int idLibro = int.Parse(Console.ReadLine());



            break;
        case 4:
            listarLibros();

            //for (int i = 0; i < listaDeLibros.Count; i++)
            //{

            //}

            //int indice = 0;
            //while(indice < listaDeLibros.Count)
            //{
            //    //ejecuta


            //    indice ++;
            //}



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

    listaDeLibros = new List<Libro>();
    // Jose Mendez = Jose Mendez + 1 -> constructor

    listaDeLibros.Add(new Libro(1, "Kamasytra", "Vatsyayana, Mallanaga", "Educativo", "9783868200355"));
    // bastian P += 1




}

