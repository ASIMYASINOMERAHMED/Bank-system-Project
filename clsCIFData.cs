//using Azure.Messaging;
//using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Net;
using System.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Permissions;
using System.Threading;
using System.Collections.Generic;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Bank_System_Project;
using BankBusinessLayer;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace BankDataAccessLayer
{
    public class clsCIFData
    {
       
    
   
        public static int AddNewCIF(string CifNumber)
        {
            int CifID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into CIF (CifNumber) values (@CifNumber)
                            Select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CifNumber", CifNumber);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedId))
                {
                    CifID = InsertedId;
                }
            }
            catch
            {
                //Later On
            }
            finally
            {
                connection.Close();
            }
            return CifID;
        }
  
        public static bool DeleteCIF(int CifID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete CIF 
                                where CifID = @CifID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CifID", CifID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);
        }
   
   
    }

}

