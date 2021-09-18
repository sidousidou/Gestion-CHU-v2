using ClassLibrary1;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ServerShowPationStart
{
    internal class implshowAllPation : MarshalByRefObject, interfaceShowPation1
    {
        String ConnectionString = @"Server=127.0.0.1;Database=hopitale;Uid=root;Pwd=sidouhaha";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="description"></param>
        /// <param name="tempirature"></param>
        /// <param name="tention"></param>
        /// <returns></returns>
        public bool adddescreption(int e, string description, int tempirature, int tention)
        {

            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = "INSERT INTO `etat_patient` (`id_patient`, `discription`, `tension`, `Date`, `tempirature`) VALUES (" + e + ", '" + description + "', " + tention + ", '" + new DateTime() + "', '" + tempirature + "');";
                    MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                    mc.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="hdebut"></param>
        /// <param name="hfin"></param>
        /// <returns></returns>
        public bool addtimefree(int e, string hdebut, string hfin)
        {try { 
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = "INSERT INTO `creneau_libre` (`heure_debut`, `heure_fin`, `idMedcin`, `Etat`) VALUES ( '" + hdebut + "', '" + hfin + "', " + e + ", '0');";
                MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                mc.ExecuteNonQuery();
            }
            return true;
        }
            catch (Exception ex)
            {
                return false;
    } 
}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="passe"></param>
        /// <returns></returns>
        public bool autontificationPation(string user, string passe)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = "SELECT * FROM medcin WHERE email LIKE '" + user + "' AND password LIKE '" + passe + "'";
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

        public bool deletetimefree(int e)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = " DELETE FROM `creneau_libre` WHERE `creneau_libre`.`id` = "+e+"";
                    MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                    mc.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable showallpation()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `patient`", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>

        public DataTable showallpationdescriptionwitheid(int e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `etat_patient` WHERE id ="+ e +"", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>

        public DataTable showallpationwitheid(string e)
        {

            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `patient` WHERE `nom` LIKE '%" + e + "%' || `prenom` LIKE '%" + e + "%'", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public MEDCIN showMedcinInformation(string s)
        {

            String sql = "SELECT * FROM medcin WHERE email LIKE '" + s + "'";



            MEDCIN c = null;


            MySqlConnection con = new MySqlConnection(ConnectionString);


            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader red;
            con.Open();
            red = cmd.ExecuteReader();
            while (red.Read())
            {
                c = new MEDCIN(red.GetInt32("id"), red.GetString("Nom"), red.GetString("prenom"));

                return c;
            }
            red.Close();
            con.Close();


            return c;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>

        public DataTable showtimefree(int e)
        {

            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `creneau_libre` WHERE `idMedcin` = "+e+"", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }
        }
    }
    internal class implshowAllPation1 : MarshalByRefObject, interfaceShowPation
    {
        public interfaceShowPation1 creer()
        {
            return new implshowAllPation();
        }
    }
}