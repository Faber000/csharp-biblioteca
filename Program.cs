public class Utente
{
    private string Nome { get; set; }
    private string Cognome { get; set; }
    private string Email { get; set; }
    private string Password { get; set; }
    private string Phone { get; set; }

    public Utente(string nome, string cognome, string email, string password, string phone)
    {
        Nome = nome;  
        Cognome = cognome;
        Email = email;
        Password = password;
        Phone = phone;
    }
}

public class Documento
{
    protected int Id { get; set; }
    protected string Titolo { get; set; }
    protected int Anno { get; set; }
    protected string Settore { get; set; }
    protected bool IsRented { get; set; }
    protected string Scaffale { get; set; }
    protected string Autore { get; set; }


    public Documento(int id, string titolo, int anno, string settore, bool isRented, string scaffale, string autore)
    {
        Id = id;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        IsRented = isRented;
        Scaffale = scaffale;
        Autore = autore;
    }
}

public class Dvd : Documento
{
    private int Durata { get; set; }
}

public class Libro : Documento
{
    private int NumPagine { get; set; }
}