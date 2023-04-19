/* Crea una classe Negozio che possa contenere una Lista di Prodotti.
 * 
 */

using CSharp_Composizione_Shop;

Negozio negozioVideogames = new Negozio("Gamestop", "Asti", "Corso Casale", 319);


Categoria genere = new Categoria("Sparatutto", "Guerra e Zombie");


Prodotto callOfDuty = new Prodotto("Call of Duty: Black Ops II", "Sparatutto in prima persona", 13.75f);
callOfDuty.SetCategoria(genere);


Prodotto skyrim = new Prodotto("The Elder Scrolls V: Skyrim", "Gioco di ruolo openworld", 14.05f);

List<Prodotto> listaVideogamesDisponibili = new List<Prodotto> { callOfDuty, skyrim };

negozioVideogames.aggiungiListaDiProdotti(listaVideogamesDisponibili);

Console.WriteLine(negozioVideogames.DammiLaTuaRappresentazioneInStringa());

Console.WriteLine();








Console.WriteLine(negozioVideogames.DammiLaTuaRappresentazioneInStringa());



Negozio negozioLibri = new("Mondadori", "Asti", "Corso Vittorio Alfieri", 329);

Prodotto delittoECastigo = new Prodotto("Delitto e Castigo", "Romanzo russo", 11.80f);

List<Prodotto> listaLibriDisponibili = new List<Prodotto> { delittoECastigo };

negozioLibri.aggiungiListaDiProdotti(listaLibriDisponibili);

Console.WriteLine(negozioLibri.DammiLaTuaRappresentazioneInStringa());
