namespace Directory
{
    class PhoneDirectory {
    static List<phoneData> agenda = new List<phoneData>();

    public phoneData this[int index] {
            get => agenda[index];
            set => agenda[index] = value;
    }

    public void addElement(){

        Console.Write("Nombre: ");
        string? name = Console.ReadLine();
        Console.Write("Numero: ");
        string? number = Console.ReadLine();
        Console.Write("Email: ");
        string?  email = Console.ReadLine();

        phoneData newElement = new phoneData(name, number, email);

        agenda.Add(newElement);
    
    }

    public void listElements(){

        if( agenda.Count == 0){

            Console.WriteLine("La agenda esta vacia");

        } else {

            for(int index = 0; index < agenda.Count; index++){
                Console.WriteLine($"Contacto {index + 1}: {agenda[index].getDate()}");
            }

        }
    
    }

    public void deleteElement(int index){
        agenda.RemoveAt(index);
        Console.WriteLine("Eliminado Satisfactoriamente");
    }

    public void updateElement(int index){
        
        Console.Write("Información antigua");
        Console.Write(agenda[index].getDate());
        Console.WriteLine("\nInformación nueva");
        Console.Write("Nombre: ");
        string? name = Console.ReadLine();
        Console.Write("Numero: ");
        string? number = Console.ReadLine();
        Console.Write("Email: ");
        string?  email = Console.ReadLine();

        phoneData auxData = new phoneData(name, number, email);
    
        agenda[index] = auxData;
    
    }

}
}