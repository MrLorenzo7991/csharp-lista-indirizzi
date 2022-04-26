using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzo
    {
        private string nome;
        private string cognome;
        private string via;
        private string citta;
        private string provincia;
        private int codicePostale;

        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, int codicePostale)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.via = via;
            this.citta = citta;    
            this.provincia = provincia;
            this.codicePostale = codicePostale;
        }
        public override string ToString()
        {
            string rigaCompleta = "-------------------\nIndirizzo di: " + nome + " " + cognome;
            rigaCompleta += "\n" + via + ", " + citta + ", " + provincia + ", " + codicePostale;
            rigaCompleta += "\n-------------------";
            return rigaCompleta;
        }
    }
}
