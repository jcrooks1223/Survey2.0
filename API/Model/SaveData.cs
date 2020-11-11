using System.Data.SQLite;
namespace API.Model
{
    public class SaveData :ISeedData
    {
        public void SeedData()
        {
 
            string cs = @"URI=file:/Users/CrisReeves/Source/Repo/Survey2.0/database/feedback.db";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS survey";
            cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE TABLE survey(id INTEGER PRIMARY KEY, Q1 TEXT,Q2 TEXT,Q3 TEXT,Q4 TEXT,Q5 TEXT, Q6 TEXT,Q7 TEXT,Q8 TEXT,Q9 TEXT,Q10 TEXT,Q11 TEXT,Q12 TEXT,Q13 TEXT,Q14 TEXT,Q15 TEXT)";
            cmd.ExecuteNonQuery();

            // cmd.CommandText = @"INSERT INTO survey(text, date) VALUES(@text, @date)";
            // cmd.Parameters.AddWithValue("@text","Mid-Terms are coming soon!!!");
            // cmd.Parameters.AddWithValue("@date","10/10/2020");
            // cmd.Prepare();
            // cmd.ExecuteNonQuery();

            // cmd.CommandText = @"INSERT INTO posts(text, date) VALUES(@text, @date)";
            // cmd.Parameters.AddWithValue("@text","Hey, nice to meet you!");
            // cmd.Parameters.AddWithValue("@date","04/20/2020");
            // cmd.Prepare();
            // cmd.ExecuteNonQuery();

            

            
        }
    }
}