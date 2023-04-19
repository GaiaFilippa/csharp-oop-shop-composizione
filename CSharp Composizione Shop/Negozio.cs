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



        // COSTRUTTORE
        public Negozio(string nomeNegozio, string citta, string indirizzo, int numeroCivico)
        {
            this.nomeNegozio = nomeNegozio;
            this.citta = citta;
            this.indirizzo = indirizzo;
            this.numeroCivico = numeroCivico;

            this.prodotti = new List<Prodotto>();

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

    }
}
