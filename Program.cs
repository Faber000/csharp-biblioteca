

List <Documento> ListaDocumenti = new List <Documento>();
List <Prestito> ListaPrestito = new List <Prestito>();
bool success = false;

Libro libro = new Libro(500, 425, "Harry Potter", 2001, "Romanzo", false, "Best Sellers", "J. K. Rowling");
ListaDocumenti.Add(libro);


Console.WriteLine("Salve, per effettuare il prestito inserisca le seguenti informazioni:");

Console.WriteLine("inserisci il tuo nome");
string nome = Console.ReadLine();

Console.WriteLine("inserisci il tuo cognome");
string cognome = Console.ReadLine();

Console.WriteLine("inserisci la tua email");
string email = Console.ReadLine();

Console.WriteLine("inserisci la tua password");
string password = Console.ReadLine();

Console.WriteLine("inserisci un recapito telefonico");
string phone = Console.ReadLine();

Utente utente_1 = new Utente(nome, cognome, email, password, phone);

Console.WriteLine("che documento vorrebbe leggere?");

string titolo = Console.ReadLine();

foreach (Documento documento in ListaDocumenti)
{
    if(documento.Titolo == titolo)
    {
        if (documento.IsRented != true)
        {
            documento.IsRented = true;

            success = true;

            Prestito prestito = new Prestito("20/09/2022", "30/09/2022", utente_1, documento);

            ListaPrestito.Add(prestito);

            Console.WriteLine("Il signor " + prestito.User.Cognome + " ha effettuato il noleggio del libro " + prestito.Document.Titolo);

        }
    }
}

if(success != true)
{
    Console.WriteLine("il documento non è disponibile");
}



