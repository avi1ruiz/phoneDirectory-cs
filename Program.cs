using Directory;

PhoneDirectory directory = new PhoneDirectory();
bool ctrl = true;

Console.Clear();

do {

    Console.WriteLine($@"
    1. Agregar Telefono
    2. Mostrar Directorio
    3. Eliminar Telefono
    4. Actualizar datos
    5. Salir
    ");

    Console.Write("Seleccione una opcion: ");
    int menuOption = Convert.ToInt32(Console.ReadLine());

    switch (menuOption) {

        case 1:
            Console.Clear();
            Console.WriteLine("Ingrese los datos");
            directory.addElement();
            Console.ReadKey();
            Console.Clear();
        break ;

        case 2:
            Console.Clear();
            Console.WriteLine("Lista de contactos");
            directory.listElements();
            Console.ReadKey();
            Console.Clear();
        break;

        case 3:
            Console.Clear();
            Console.Write("Seleccione elemento que desea eliminar: ");
            int indexDel = Convert.ToInt32(Console.ReadLine()) - 1;

            directory.deleteElement(indexDel);
            Console.ReadKey();
            Console.Clear();
        break;

        case 4:
            Console.Clear();
            Console.Write("Seleccione elemento que desea actualizar: ");
            int indexUpd = Convert.ToInt32(Console.ReadLine()) - 1;

            directory.updateElement(indexUpd);
            Console.ReadKey();
            Console.Clear();
        break;

        case 5:
            ctrl = false;
        break;

    }    

} while (ctrl);

Console.WriteLine("El programa ha finalizado");
Console.ReadKey();
Console.Clear();