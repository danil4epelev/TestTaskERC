using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestTaskERC.Models;

namespace TestTaskERC
{
    public static class DatabaseQuies
    { 
        public static void UpdateClient(int id, double hotWater, double coldWater, double electricityDay, double electricityNight)
        {
            const string sqlExpression = "sp_UpdateClient";

            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    AddParamToStoredProcedure(command, id, "@id");

                    AddParamToStoredProcedure(command, hotWater, "@hotWater");
                    AddParamToStoredProcedure(command, coldWater, "@coldWater");
                    AddParamToStoredProcedure(command, electricityDay, "@electricityDay");
                    AddParamToStoredProcedure(command, electricityNight, "@electricityNight");

                    var result = command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка! Обратитесь к администратору", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static  List<BackgroundInformation> GetBackgroundInformation()
        {
            const string sqlExpression = "sp_SelectBackgroundInformation";

            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = command.ExecuteReader();

                    List<BackgroundInformation> list = new List<BackgroundInformation>();

                    if (reader.HasRows)
                    {                       
                        while (reader.Read())
                        {
                            string service = reader.GetString(0);
                            double rate = reader.GetDouble(1);
                            double standard = reader.GetDouble(2);
                            string measurement = reader.GetString(5);

                            BackgroundInformation backgroundInformation = new BackgroundInformation(service, rate, standard, measurement);

                            list.Add(backgroundInformation);
                        }
                    }
                    reader.Close();

                    return list;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка! Обратитесь к администратору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static int AddUserToDB(double hotWater, double coldWater, double electricityDay, double electricityNight)
        {
            const string sqlExpression = "sp_CreateClient";

            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    // указываем, что команда представляет хранимую процедуру
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    AddParamToStoredProcedure(command, hotWater, "@hotWater");
                    AddParamToStoredProcedure(command, coldWater, "@coldWater");
                    AddParamToStoredProcedure(command, electricityDay, "@electricityDay");
                    AddParamToStoredProcedure(command, electricityNight, "@electricityNight");

                    var result = command.ExecuteScalar();

                    connection.Close();

                    int id = (int)((decimal)result);

                    return id;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка! Обратитесь к администратору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }


        }

        public static User FindUser(int id)
        {
            const string sqlExpression = "sp_GetClientMeter";
            
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    AddParamToStoredProcedure(command, id, "@id");


                    var reader = command.ExecuteReader();
                    User user = null;
                    if (reader.Read())
                    {
                       user = new User(id, reader.GetDouble(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4));
                    }
                    

                    reader.Close();
                    connection.Close();

                    return user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка! Обратитесь к администратору", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static void AddParamToStoredProcedure<T>(SqlCommand command, T val, string nameVariable)
        {
            SqlParameter Param = new SqlParameter
            {
                ParameterName = nameVariable,
                Value = val
            };
            command.Parameters.Add(Param);
        }
    }
}
