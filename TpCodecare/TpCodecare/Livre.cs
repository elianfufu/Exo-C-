using System;
using System.Collections.Generic;
using System.Text;

namespace TpCodecare
{
    class Livre
    {
        private string code;
        private string titre;
        private string auteur;
        private int page;
        private string disp;
        private List<string> id;


        public Livre(string Code, string Titre, string Auteur, int Page)
        {
            this.code = Code;
            this.titre = Titre;
            this.auteur = Auteur;
            this.page = Page;
            this.disp = "disponible";
            this.id = new List<string>();
        }

        public string CodeISBN
        {
            get { return code; }
            set { code = value; }
        }
        public string Titres
        {
            get { return titre; }
            set { titre = value; }
        }
        public string Auteurs
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public int Pages
        {
            get { return page; }
            set { page = value; }
        }
        public string Disponibilite
        {
            get { return disp; }
            set { disp = value; }
        }
        public List<string> addID
        {
            get { return id; }
            set { id = value; }
        }
        
        public string AfficherInfo()
        {
            string[] infos = new string[5];
            infos[0] = this.CodeISBN;
            infos[1] = this.Titres;
            infos[2] = this.Auteurs;
            infos[3] = this.Pages.ToString();
            infos[4] = this.Disponibilite;
            return "Titre : " + infos[1] + "\nAuteur : " + infos[2] + "\nCode ISBN : " + infos[0] + "\nNombre de pages : " + infos[3] + "\nDisponibilité : " + infos[4];
        }
        public string AfficherLivres()
        {
            string[] infos = new string[5];
            infos[0] = this.CodeISBN;
            infos[1] = this.Titres;
            infos[2] = this.Disponibilite;
            return infos[1] + " est " + infos[2] + ", code ISBN: " + infos[0];
        }
    }

}
