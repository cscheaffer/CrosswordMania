using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using UnityEngine;
using Dapper;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace CrosswordDLL
{
    public class CrosswordCalculations
    {
        string cs = Helper.CnnVal();
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string GetWord(string word)
        {
            string val = "";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Words WHERE Word=@Word";
                cmd.Parameters.AddWithValue("@Word", word);
                cmd.Connection = connection;
                connection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        val = oReader["Word"].ToString();
                    }

                    connection.Close();
                }
                // Data is accessible through the DataReader object here.
                return val;
            }
        }
        public string GetClue(string clue)
        {
            string val = "";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT Clue FROM Words WHERE Clue=@Clue";
                cmd.Parameters.AddWithValue("@Clue", clue);
                cmd.Connection = connection;
                connection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        val = oReader["Clue"].ToString();
                    }

                    connection.Close();
                }
                // Data is accessible through the DataReader object here.
                return val;
            }
        }
    }
}
