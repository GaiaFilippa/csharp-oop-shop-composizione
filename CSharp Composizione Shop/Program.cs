/* Crea una classe Negozio che possa contenere una lista di prodotti.
 * 
 */

using CSharp_Composizione_Shop;

Negozio negozioVideogames = new Negozio("Gamestop", "Asti", "Corso Casale", 319);

Prodotto callOfDuty = new Prodotto("Call of Duty: Black Ops II", "Sparatutto in prima persona", 13.75f);
Prodotto skyrim = new Prodotto("The Elder Scrolls V: Skyrim", "Gioco di ruolo openworld", 14.05f);

List<Prodotto> listaVideogamesDisponibili = new List<Prodotto> { callOfDuty, skyrim };

negozioVideogames.aggiungiListaDiProdotti(listaVideogamesDisponibili);

Console.WriteLine(negozioVideogames.DammiLaTuaRappresentazioneInStringa());