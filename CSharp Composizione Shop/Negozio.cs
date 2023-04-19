using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Negozio
    {
        // ATTRIBUTI
        private string nomeNegozio;
        private string citta;
        private string indirizzo;
        private int numeroCivico;
        private List<Prodotto> prodotti;
        private List<Categoria> categoria;



        // COSTRUTTORE
        public Negozio(string nomeNegozio, string citta, string indirizzo, int numeroCivico)
        {
            this.nomeNegozio = nomeNegozio;
            this.citta = citta;
            this.indirizzo = indirizzo;
            this.numeroCivico = numeroCivico;

            this.prodotti = new List<Prodotto>();
            this.categoria = new List<Categoria>();

        }


        // GETTERS
        public string GetNomeNegozio()
        {
            return this.nomeNegozio;
        }

        public string GetCitta()
        {
            return this.citta;
        }

        public string GetIndirizzo()
        {
            return this.indirizzo;
        }
        public int GetNumeroCivico()
        {
            return this.numeroCivico;
        }

        public List<Prodotto> GetListaProdotti()
        {
            return this.prodotti;
        }

        // SETTERS



        // METODI
        public void aggiungiListaDiProdotti(List<Prodotto> listaDiProdottiDaAggiungere)
        {

            foreach (Prodotto nuovoProdottoDaAggiungere in listaDiProdottiDaAggiungere)
            {
                this.prodotti.Add(nuovoProdottoDaAggiungere);
            }

        }



        public void aggiungiCategoria(List<Categoria> categoriaDaAggiungere)
        {

            foreach (Categoria aggiuntaCategoria in categoriaDaAggiungere)
            {
                this.categoria.Add(aggiuntaCategoria);
            }

        }

        public string DammiLaTuaRappresentazioneInStringa()
        {
            string rapprStringa = "Nome del Negozio: " + this.nomeNegozio + "\n";
            rapprStringa += "Città: " + this.citta + "\n";
            rapprStringa += "Indirizzo: " + this.indirizzo + ", " + this.numeroCivico + "\n";
            rapprStringa += "Prodotti: \n";

            foreach (Prodotto prodottoScansionato in prodotti)
            {
                rapprStringa += prodottoScansionato.GetProdottoStringa() + "\n";
            }

            foreach (Categoria categoriaScansionata in categoria)
            {
                rapprStringa += categoriaScansionata.GetCategoriaStringa() + "\n";
            }

            rapprStringa += "\n";

            return rapprStringa;
        }

    }
}
