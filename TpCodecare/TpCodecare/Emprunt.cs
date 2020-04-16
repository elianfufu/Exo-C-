using System;
using System.Collections.Generic;
using System.Text;

namespace TpCodecare
{
    class Emprunt
    {
        DateTime date = DateTime.Today;    
        public void emprunter(Livre livre, Personne personne)
        {
            livre.Disponibilite = "indisponible";
            personne.addID.Add(livre.CodeISBN);
            livre.addID.Add(personne.noms);
            personne.Date.Add(date);
        }

        public void rendre(Livre livre, Personne personne)
        {
            livre.Disponibilite = "disponible";
            personne.addID.Remove(livre.CodeISBN);
            livre.addID.Remove(personne.noms);
            personne.Date.Remove(date);
        }
    }
}


