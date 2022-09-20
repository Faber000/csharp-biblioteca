

Libro libro_1 = new Libro(500, 425, "Harry Potter", 2001, "Romanzo", false, "Best Sellers", "J. K. Rowling");
Utente utente_1 = new Utente("Fabio", "Moro", "fabio.moro@gmail.com", "password123", "3336888785");

Prestito prestito_1 = new Prestito("20/09/2022", "30/09/2022", utente_1, libro_1);

Console.WriteLine("Il signor " + prestito_1.User.Cognome + " ha noleggiato il libro " + prestito_1.Document.Titolo);