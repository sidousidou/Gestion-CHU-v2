using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable]
    public class MEDCIN
    {
        int id;
        string name;
        string prename;

        public MEDCIN(int id, string name, string prename)
        {
            this.Id = id;
            this.Name = name;
            this.Prename = prename;
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
