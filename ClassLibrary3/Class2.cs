using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{[Serializable]
   public class Class2
    {
        int id;
        string name;
        string prename;

       public Class2 (int id,string name, string prename)
        {
            this.id = id;
            this.name = name;
            this.prename = prename;
        }
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Prename
        {
            get
            {
                return prename;
            }

            set
            {
                prename = value;
            }
        }
    }
}
