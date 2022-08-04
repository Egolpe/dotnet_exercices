
Clients miCliente = new Clients();

Clients miCliente2 = miCliente with { NombreCompleto = "Enrique Golpe Ares", Telefono = 666777888, Direccion = "avenida tilos 8", Email = "enriquegolpe@gmail.com", EsNuevo = true};
Console.WriteLine(miCliente2);

public struct Clients
{
    public Clients(String nombreCompleto, int telefono, String direccion, String email, bool esNuevo)
    {

        NombreCompleto = nombreCompleto;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        EsNuevo = esNuevo;
       
    }

        public String NombreCompleto { get; set; }

        public int Telefono { get; set; }

        public String Direccion { get; set; }

        public String Email { get; set; }

        public bool EsNuevo { get; set; }

   

    public override string ToString() => $"{NombreCompleto}, {Telefono}, {Direccion}, {Email}, {EsNuevo} ";
    
    
}