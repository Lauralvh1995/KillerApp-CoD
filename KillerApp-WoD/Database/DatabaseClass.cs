using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KillerApp_WoD.Database
{
    class DatabaseClass
    {
        SqlConnection myConnection = new SqlConnection("user id=User;" +
                                       "server=DESKTOP-E33041D\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=WoDDatabase; " +
                                       "connection timeout=15");

        public List<string> characters = new List<string>();
        public int currentUserID;

        public void OpenConnection()
        {
            try
            {
                myConnection.Open();
                Console.WriteLine("Databaseconnection succeeded");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
                Console.WriteLine("Databaseconnection closed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public bool LogIn(string username, string password)
        {
            
                try
                {
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand("SELECT * FROM Account WHERE email = @email AND pword = @password", myConnection);
                    myCommand.Parameters.AddWithValue("email", username);
                    myCommand.Parameters.AddWithValue("password", password);
                    myReader = myCommand.ExecuteReader();
                    Console.WriteLine("test");
                    while (myReader.Read())
                    {
                        Console.WriteLine("Test gelukt");
                        Console.WriteLine(myReader["id"]);
                        Console.WriteLine(myReader["email"].ToString());
                        if (myReader["id"].ToString().Length > 0)
                        {
                            currentUserID = Convert.ToInt32(myReader["id"]);
                        }
                        else
                        {
                            MessageBox.Show("Er is een fout opgetreden. Uw gebruikersnaam of wachtwoord is incorrect.");
                            return false;
                        }
                    }
                    return true;
                }
                catch
                {
                    Console.WriteLine("Er is een fout opgetreden.");
                    return false;
                }

            
        }
    }
}

