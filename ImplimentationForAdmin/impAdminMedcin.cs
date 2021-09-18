using interfaceMedcin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplimentationForAdmin
{
    public class impAdminMedcin : MarshalByRefObject, interfaceMedcinAdmin
    {
        string ConnectionString = @"Server=127.0.0.1;Database=hopitale;Uid=root;Pwd=;";

        public bool addinfermier(infermier e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool addMedcine(Medcine e)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    string q = "INSERT INTO `medcin` (`Nom`, `prenom`, `email`, `password`) VALUES ( '" + e.Nom + "', '" + e.Prenom + "', '" + e.User + "', '" + e.Passe + "');";
                    MySqlCommand mc = new MySqlCommand("AddEditmedcin", mysqlcon);

                    mc.ExecuteNonQuery();

                }
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }

        public bool addpation(pation e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="passe"></param>
        /// <returns></returns>

        public bool auto(String user, String passe)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                string query = "SELECT * FROM admin WHERE mail LIKE '" + user+ "' AND password LIKE '" + passe + "'";
                MySqlDataAdapter mc = new MySqlDataAdapter(query, mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                if (a.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool deleteinfermier(int e)
        {
            throw new NotImplementedException();
        }

        public bool deleteMedcine(int e)
        {
            throw new NotImplementedException();
        }

        public bool deleteMedcine(Medcine e)
        {
            return true;
        }

        public bool deletepation(int e)
        {
            throw new NotImplementedException();
        }

        public DataTable searcheinfermier(string e)
        {
            throw new NotImplementedException();
        }

        public DataTable searchepation(string e)
        {
            throw new NotImplementedException();
        }

        public DataTable searcheWithId(string e)
        {
            throw new NotImplementedException();
        }

        public DataTable showallinfermier()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable showallMedcin()
        {
            string q = "SELECT * FROM `medcin`;";
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                string query = "SELECT * FROM medcin";
                MySqlDataAdapter mc = new MySqlDataAdapter(query, mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;

            }
        }

        public DataTable showallpation()
        {
            throw new NotImplementedException();
        }

        public bool Update(Medcine e)
        {
            throw new NotImplementedException();
        }

        public bool Updateinfermier(infermier e)
        {
            throw new NotImplementedException();
        }

        public bool Updatepation(pation e)
        {
            throw new NotImplementedException();
        }
    }
}
