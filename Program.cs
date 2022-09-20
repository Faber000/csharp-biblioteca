List <Documento> ListaDocumenti = new List <Documento>();
List <Prestito> ListaPrestito = new List <Prestito>();
List <Utente> ListaUtente = new List <Utente>();
bool success = false;
string scelta;

do
{
    Console.WriteLine("Inserire 1 per aggiungere un documento");
    Console.WriteLine("Inserire 2 per noleggiare un documento");
    Console.WriteLine("Inserire 3 per cercare un prestito");
    Console.WriteLine("-1 per terminare");

    scelta = Console.ReadLine();

    switch(scelta)
    {
        case "1":
            InserisciDocumento();
            break;
        case "2":
            EffettuaPrestito();
            break;
        case "3":
            RicercaPrestito();
            break;
        default:
            break; 
    }

} while(scelta != "-1");

void RicercaPrestito()
{
    bool found = false;
    Console.WriteLine("inserisci il cognome dell'utente");
    string cognome = Console.ReadLine();

    foreach(Prestito prestito in ListaPrestito)
    {
        if(prestito.User.Cognome==cognome)
        {
            found = true;
            Console.WriteLine("\r\n");
            Console.WriteLine("INFORMAZIONI SUL PRESTITO: ");
            Console.WriteLine("DOCUMENTO IN PRESTITO: "+ prestito.Document.Titolo);
            Console.WriteLine("\r\n");

        }
    }

    if(found==false)
    {
        Console.WriteLine("nesun prestito trovato");
    }

}
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

                Console.WriteLine("\r\n");
                Console.WriteLine("IL SIGNOR " + prestito.User.Cognome + " HA EFFETTUATO IL NOLEGGIO DEL LIBRO " + prestito.Document.Titolo);
                Console.WriteLine("\r\n");
            }
        }
    }

    if (success != true)
    {
        Console.WriteLine("il documento non è disponibile");
    }
}




