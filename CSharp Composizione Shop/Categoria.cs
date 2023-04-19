using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class Categoria
    {
        private string nomeCategoria;
        private string descrizioneCategoria;


        // COSTRUTTORE
        public Categoria(string nomeCategoria, string descrizioneCategoria)
        {
            this.nomeCategoria = nomeCategoria;
            this.descrizioneCategoria = descrizioneCategoria;
            
        }


        // GETTERS
        public string GetNomeCategoria()
        {
            return this.nomeCategoria;
        }

        public string GetDescrizioneCategoria()
        {
            return this.descrizioneCategoria;
        }

        // SETTERS


        // METODI
        public string GetCategoriaStringa()
        {
            string rapprStringa = "Categoria: " + this.nomeCategoria + ", ";
            rapprStringa += "Descrizione: " + this.descrizioneCategoria;

            return rapprStringa;
        }


    }
}
