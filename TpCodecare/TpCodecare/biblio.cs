using System;
using System.Collections.Generic;
using System.Text;

namespace TpCodecare
{
    class Biblio
    {
        private List<Livre> livres;
        public Biblio()
        {
            livres = new List<Livre>();
        }
        public Biblio(List<Livre> livres)
        {
            this.livres = new List<Livre>(livres);
        }
    }
}
