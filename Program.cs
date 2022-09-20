List <Documento> ListaDocumenti = new List <Documento>();
List <Prestito> ListaPrestito = new List <Prestito>();
List <Utente> ListaUtente = new List <Utente>();
bool success = false;
string scelta;

do
{
    Console.WriteLine("Inserire 1 per aggiungere un documento");
    Console.WriteLine("Inserire 2 per noleggiare un documento");
    Console.WriteLine("-1 per terminare");

    scelta = Console.ReadLine();

    if (scelta == "1")
    {
        InserisciDocumento();
    }

    else if (scelta == "2")

    {
        EffettuaPrestito();
    }

} while(scelta != "-1");


void InserisciDocumento()
{
    Console.WriteLine("Salve, per effettuare l'inserimento di un documento inserisca le seguenti informazioni");

    Console.WriteLine("Libro o Dvd? L/D");
    string response = Console.ReadLine();

    Console.WriteLine("inserisci il titolo");
    string titolo = Console.ReadLine();

    Console.WriteLine("inserisci l'autore");
    string autore = Console.ReadLine();

    if(response=="L")
    {
        Console.WriteLine("inserisci il numero di pagine");
        int numPagine = Convert.ToInt32(Console.ReadLine());
        Libro libro = new Libro(titolo, autore, numPagine);
        ListaDocumenti.Add(libro);
    } 

    else
    {
        Console.WriteLine("inserisci la durata");
        int durata = Convert.ToInt32(Console.ReadLine());
        Dvd dvd = new Dvd(titolo, autore, durata);
        ListaDocumenti.Add(dvd);
    }
}

void EffettuaPrestito()
{
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

    Utente utente = new Utente(nome, cognome, email, password, phone);
    ListaUtente.Add(utente);

    Console.WriteLine("che documento vorrebbe leggere?");

    string titolo = Console.ReadLine();

    foreach (Documento documento in ListaDocumenti)
    {
        if (documento.Titolo == titolo)
        {
            if (documento.IsRented != true)
            {
                documento.IsRented = true;

                success = true;

                Prestito prestito = new Prestito("20/09/2022", "30/09/2022", utente, documento);

                ListaPrestito.Add(prestito);

                Console.WriteLine("Il signor " + prestito.User.Cognome + " ha effettuato il noleggio del libro " + prestito.Document.Titolo);

            }
        }
    }

    if (success != true)
    {
        Console.WriteLine("il documento non è disponibile");
    }
}




