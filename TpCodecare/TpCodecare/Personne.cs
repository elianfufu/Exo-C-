using System;
using System.Collections.Generic;
using System.Text;

namespace TpCodecare
{
    class Personne
    {
        private string nom;
        private string prenom;
        private string login;
        private string mdp;
        private Role role;
        private List<string> id;
        private List<DateTime> date;

        public Personne(string Nom, string Prenom, string Login, string Mdp, Role Role)
        {
            this.nom = Nom;
            this.prenom = Prenom;
            this.login = Login;
            this.mdp = Mdp;
            this.role = Role;
            this.id = new List<string>();
            this.date = new List<DateTime>();
        }
        public Personne()
        {

        }

        public Role roles
        {
            get { return role; }
            set { role = value; }
        }
        public string noms
        {
            get { return nom; }
            set { nom = value; }
        }
        public string prenoms
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string logins
        {
            get { return login; }
            set { login = value; }
        }
        public string mdps
        {
            get { return mdp; }
            set { mdp = value; }
        }
        public List<string> addID
        {
            get { return id; }
            set { id = value; }
        }
        public List<DateTime> Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
