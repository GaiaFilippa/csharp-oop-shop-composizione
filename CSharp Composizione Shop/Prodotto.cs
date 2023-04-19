﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Prodotto
    {
        // ATTRIBUTI
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private Categoria categoria;


        // STATI


        // COSTRUTTORE
        public Prodotto(string nome, string descrizione, float prezzo)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;

            Random codiceRandom = new Random();
            int codice = codiceRandom.Next();
            this.codice = codice;

        }

        // GETTERS

        public int GetCodice()
        {
            return codice;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public string GetNome()
        {
            return this.nome;
        }

        // SETTERS

        public float SetPrezzo()
        {
            return (float)this.prezzo;
        }

        public Categoria GetCategoria()
        {
            return this.categoria;
        }

        public void SetCategoria( Categoria categoria)
        {
            this.categoria = categoria;
        }

        // METODI

        public string ConcatenaNomeECodice()
        {
            string nomeECodice = nome + this.codice;
            return nomeECodice;
        }

        public string GetProdottoStringa()
        {
            string rapprStringa = "Nome del prodotto: " + this.nome + "\n";
            rapprStringa += "Descrizione del prodotto: " + this.descrizione + "\n";
            rapprStringa += "Prezzo: " + this.prezzo + " euro" + "\n";
            rapprStringa += "Codice: " + this.codice;

            return rapprStringa;
        }

       

    }
}