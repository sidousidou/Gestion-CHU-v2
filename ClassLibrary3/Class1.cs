using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public   interface interfaceInfermier
    {
        DataTable showallpation();
        DataTable showallpationwitheid(string e);
        bool autontificationPation(string user, string passe);
        DataTable showallMedcin();

        Class2 getInfermier(String s);
        DataTable showtimefree(int e);
        bool validerRendivous(int i);
        bool devaliderRendivous(int i);
        bool ajouterRendiveaux(int idPation,int medcin);

    }
    public interface fabriqueInfermier
    {
        interfaceInfermier creer();
    }
}
