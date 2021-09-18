using interfaceMedcin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverStarte
{
    class implimentationAdminMedcin : MarshalByRefObject, interfaceMedcinAdmin
    {
        String ConnectionString = @"Server=127.0.0.1;Database=hopitale;Uid=root;Pwd=sidouhaha";

        public bool addinfermier(infermier e)
        {try { 
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = "INSERT INTO `infermier` (`nom`, `prenom`, `mail`, `password`)  VALUES ( '" + e.Nom + "','" + e.Prenom + "' ,'" + e.User + "' , '" + e.Passe + "');";
                MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                mc.ExecuteNonQuery();
            }
            return true;
        }catch(Exception ex)
            {
                return false;
    }
}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool addMedcine(Medcine e)
        {try { 
           /* using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlCommand mc = new MySqlCommand("AddEditmedcin", mysqlcon);
                mc.CommandType = CommandType.StoredProcedure;
                mc.Parameters.AddWithValue("_ID", e.Id);
                mc.Parameters.AddWithValue("_Name", e.Nom);
                mc.Parameters.AddWithValue("_lastName", e.Prenom);
                mc.Parameters.AddWithValue("_user", e.User);
                mc.Parameters.AddWithValue("_Passe", e.Passe);
                mc.ExecuteNonQuery();
            }*/
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = "INSERT INTO `medcin` (`Nom`, `prenom`, `email`, `password`) VALUES ( '"+e.Nom+"','"+e.Prenom+"' ,'"+e.User+"' , '"+e.Passe+"')";
                    MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                    mc.ExecuteNonQuery();
                }
                    return true;
            }catch(Exception ex)
            {
                return false;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool addpation(pation e)
        {//try { 
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = "INSERT INTO `patient` (`nom`, `prenom`, `age`, `sex`) VALUES ('"+e.Nom+"', '"+e.Prenom+"', '"+e.Age+"', '"+e.Sex+"');";
                MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                mc.ExecuteNonQuery();
            }
            return true;
       /* }catch(Exception ex)
            {
                return false;
    }*/

}

/// <summary>
/// 
/// </summary>
/// <param name="user"></param>
/// <param name="passe"></param>
/// <returns></returns>
public bool auto(string user, string passe)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = "SELECT * FROM admin WHERE mail LIKE '" + user+ "' AND password LIKE '" + passe+ "'";
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>

        public bool deleteinfermier(int e)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = " DELETE FROM `infermier` WHERE `infermier`.`id` = '" + e + "';";
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
        /// <returns></returns>
        public bool deleteMedcine(int e)
        {try { 
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = " DELETE FROM `medcin` WHERE `medcin`.`id` = '"+e+"';";
                MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                mc.ExecuteNonQuery();
            }
            return true;
        }catch(Exception ex)
            {
                return false;
    }
}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>

        public bool deletepation(int e)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = " DELETE FROM `patient` WHERE `patient`.`id` = '" + e + "';";
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

        public DataTable searcheinfermier(string e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `infermier` WHERE `Nom` LIKE '%" + e + "%' || `prenom` LIKE '%" + e + "%'", mysqlcon);

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
        public DataTable searchepation(string e)
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
        /// <param name="e"></param>
        /// <returns></returns>
        public DataTable searcheWithId(string e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `medcin` WHERE `Nom` LIKE '%"+e+"%' || `prenom` LIKE '%"+e+"%'", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }
        }

        public DataTable showallinfermier()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                MySqlDataAdapter mc = new MySqlDataAdapter("SELECT * FROM `infermier`", mysqlcon);

                DataTable a = new DataTable();
                mc.Fill(a);
                return a;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

        public bool Update(Medcine e)
        {
            try { 
            using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
            {
                mysqlcon.Open();
                String query = "UPDATE `medcin` SET `Nom` = '"+e.Nom+"',`prenom` = '"+e.Prenom+"',`email` = '"+e.User+"',`password`= '"+e.Passe+"' WHERE `id`='"+e.Id+"'; ";
                MySqlCommand mc = new MySqlCommand(query, mysqlcon);
                mc.ExecuteNonQuery();
            }
            return true;
        }catch(Exception ex)
            {
                return false;
            }
}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool Updateinfermier(infermier e)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = "UPDATE `infermier` SET `Nom` = '" + e.Nom + "',`prenom` = '" + e.Prenom + "',`mail` = '" + e.User + "',`password`= '" + e.Passe + "' WHERE `id`='" + e.Id + "'; ";
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
        /// <returns></returns>
        public bool Updatepation(pation e)
        {
            try
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(ConnectionString))
                {
                    mysqlcon.Open();
                    String query = "UPDATE `patient` SET `nom` = '"+e.Nom+ "', `prenom` = '" + e.Prenom + "', `age` = " + e.Age + ", `sex` = '" + e.Sex + "' WHERE `patient`.`id` = "+ e.Id+ "; ";
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
}
