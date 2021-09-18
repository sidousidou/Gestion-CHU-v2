using System.Data;

namespace ClassLibrary1
{
    public interface interfaceShowPation1
    {
        DataTable showallpation();
        DataTable showallpationwitheid(string e);
        bool autontificationPation(string user, string passe);
        MEDCIN showMedcinInformation(string s);
        DataTable showallpationdescriptionwitheid(int e);
        bool adddescreption(int e,string description,int tempirature,int tention);
        bool addtimefree(int e, string hdebut, string hfin);
        bool deletetimefree(int e);
        DataTable showtimefree(int e);
    }
    public interface interfaceShowPation
    {
        interfaceShowPation1 creer();
    }
}