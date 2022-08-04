namespace Directory
{
    struct phoneData {
    
    private string? name, email, number;

    public phoneData(string? name, string? number, string? email){
    
        this.name = name;
        this.number = number;
        this.email = email;
    
    }
    public string? getDate(){
        
        return $@"
        Nombre: {name}
        Numero: {number} 
        Email: {email}";
    
    }

}
}