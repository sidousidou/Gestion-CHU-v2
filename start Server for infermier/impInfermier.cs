using ClassLibrary3;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_Server_for_infermier
{
    class impInfermier: MarshalByRefObject, interfaceInfermier
    {
        String ConnectionString = @"Server=127.0.0.1;Database=hopitale;Uid=root;Pwd=sidouhaha";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPation"></param>
        /// <param name="medcin"></param>
        /// <returns></returns>
        public bool ajouterRendiveaux(int idPation, int medcin)
        {

            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {//UPDATE `creneau_libre` SET `Etat` = '1' WHERE `creneau_libre`.`id` = 6;
                    mysqlcon.Open();
                    String query = "INSERT INTO `rdv` ( `id_patient`, `id_medc`) VALUES ( "+ idPation + ", '"+ medcin+"');";
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
                String query = "SELECT * FROM infermier WHERE mail LIKE '" + user + "' AND password LIKE '" + passe + "'";
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

        public bool devaliderRendivous(int i)
        {

            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {//UPDATE `creneau_libre` SET `Etat` = '1' WHERE `creneau_libre`.`id` = 6;
                    mysqlcon.Open();
                    String query = "UPDATE `creneau_libre` SET `Etat` = '0' WHERE `creneau_libre`.`id` = "+i+";";
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

        public Class2 getInfermier(string s)
        {


            
                String sql = "SELECT * FROM infermier WHERE mail LIKE '" + s + "'";

               

                Class2 c =null;

               
                MySqlConnection con = new MySqlConnection(ConnectionString);
                    

                    MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader red;
                    con.Open();
                red= cmd.ExecuteReader();
                    while (red.Read())
                    {
                c = new Class2(red.GetInt32("id"), red.GetString("nom"),red.GetString("prenom"));
          
                return c;
                }
                red.Close();
                    con.Close();
                
           
            return c;

        }

        public DataTable showallMedcin()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `medcin`", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
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

        public DataTable showtimefree(int e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `creneau_libre` WHERE `idMedcin` = " + e + "", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }
        
    }

        public bool validerRendivous(int i)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {//UPDATE `creneau_libre` SET `Etat` = '1' WHERE `creneau_libre`.`id` = 6;
                    mysqlcon.Open();
                    String query = "UPDATE `creneau_libre` SET `Etat` = '1' WHERE `creneau_libre`.`id` = " + i + ";";
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
    }
    class impFabrique : MarshalByRefObject, fabriqueInfermier
    {
        public interfaceInfermier creer()
        {
            return new impInfermier();
        }
    }
}
