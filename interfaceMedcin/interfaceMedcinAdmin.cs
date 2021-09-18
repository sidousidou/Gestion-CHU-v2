using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceMedcin
{
    public interface interfaceMedcinAdmin
    {
        Boolean addMedcine(Medcine e);
        Boolean Update(Medcine e);
        Boolean deleteMedcine(int e);
        Boolean auto(String user,String passe);
        DataTable showallMedcin();
        DataTable searcheWithId(string e);
        //
        Boolean addinfermier(infermier e);
        Boolean Updateinfermier(infermier e);
        Boolean deleteinfermier(int e);
       
        DataTable showallinfermier();
        DataTable searcheinfermier(string e);

        //
        Boolean addpation(pation e);
        Boolean Updatepation(pation e);
        Boolean deletepation(int e);

        DataTable showallpation();
        DataTable searchepation(string e);
    }
}
