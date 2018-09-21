using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace CrosswordDLL
{
    public class Helper
    {
        public static string CnnVal()
        {
            return "Server = tcp:oatmealrains.database.windows.net,1433; Initial Catalog = Crossword; Persist Security Info = False; User ID = username; Password =username; MultipleActiveResultSets = False; Encrypt = False; Connection Timeout = 30; Integrated Security=False ";
        }

        public static void UploadData(List<Word> list, string tablename)
        {
            using (SqlConnection connection = new SqlConnection(CnnVal()))
            {
                for(int i = 0; i < list.Count; i++)
                {
                    var command = new SqlCommand("INSERT INTO " + tablename + " VALUES(@Word, @Clue, @Category");
                    command.Parameters.AddWithValue("@Word" , list[i].Name);
                    command.Parameters.AddWithValue("@Clue", list[i].Clue);
                    command.Parameters.AddWithValue("@Category", list[i].Category);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
