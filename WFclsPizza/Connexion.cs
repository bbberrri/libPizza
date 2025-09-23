using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace WFclsPizza
{
    internal class Connexion
    {
        private SqlConnection connection;
        private string connectionString;

        // Constructeur avec chaîne de connexion
        public Connexion(string connectionString)
        {
            this.connectionString = connectionString;
            this.connection = new SqlConnection(connectionString);
        }

        // Méthode pour ouvrir la connexion
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Méthode pour fermer la connexion
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Exécution d'une requête SELECT avec SqlCommand
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                // Création de l'objet SqlCommand lié à la connexion
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Création de l'adaptateur de données
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        // Exécution d'une requête avec paramètres
        public DataTable ExecuteParameterizedQuery(string query, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajout des paramètres à la commande
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        // Exécution d'une commande INSERT, UPDATE ou DELETE
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return rowsAffected;
        }

        // Exécution d'une commande avec paramètres
        public int ExecuteNonQueryWithParameters(string query, SqlParameter[] parameters)
        {
            int rowsAffected = 0;

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return rowsAffected;
        }

        // Exécution d'une requête qui retourne une seule valeur
        public object ExecuteScalar(string query)
        {
            object result = null;

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    result = command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'exécution de la requête : {ex.Message}");
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        // Méthode pour libérer les ressources
        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
