public class Libro : Documento
{
    public int NumPagine { get; set; }

    public Libro(int NumPagine, int Id, string Titolo, int Anno, string Settore, bool IsRented, string Scaffale, string Autore) : base(Id, Titolo, Anno, Settore, IsRented, Scaffale, Autore)
    {
        this.NumPagine = NumPagine;
    }
}
