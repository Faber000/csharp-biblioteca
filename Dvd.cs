public class Dvd : Documento
{
    public int Durata { get; set; }

    public Dvd(int Durata, int Id, string Titolo, int Anno, string Settore, bool IsRented, string Scaffale, string Autore) : base(Id, Titolo, Anno, Settore, IsRented, Scaffale, Autore)
    {
        this.Durata = Durata;
    }
}
