using System;

namespace interfaceMedcin
{
    [Serializable]
    public class Medcine
    {
        int id;
        string nom;
        string prenom;
        string user;
        string passe;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Passe
        {
            get
            {
                return passe;
            }

            set
            {
                passe = value;
            }
        }
    }
}