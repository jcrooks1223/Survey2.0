using System.Security.AccessControl;
using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace API.Model
{
    public class RealData: IRead,IGetFeeback
    {
       public List<Survey> GetAllSurvey()
       {
           List<Survey> allSurvey = new List<Survey>();
            string cs = @"URI=file:/Users/CrisReeves/Source/Repo/Feedback/feedback.db";
        

            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM survey";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Survey temp = new Survey(){ID=rdr.GetInt32(0),Lead1=rdr.GetInt32(1),Lead2=rdr.GetInt32(2),Lead3=rdr.GetInt32(3),Lead4=rdr.GetInt32(4),Lead5=rdr.GetInt32(5),Comm1=rdr.GetInt32(6),Comm2=rdr.GetInt32(7),Comm3=rdr.GetInt32(8),Comm4=rdr.GetInt32(9),Comm5=rdr.GetInt32(10),Tech1=rdr.GetInt32(11),Tech2=rdr.GetInt32(12),Tech3=rdr.GetInt32(13),Tech4=rdr.GetInt32(14),Tech5=rdr.GetInt32(15)};
                allSurvey.Add(temp);
            }

           return allSurvey;
       }

        public Survey GetSurvey(int id)
        {
            List<Survey> allSurvey = new List<Survey>();
            string cs = @"URI=file:/Users/CrisReeves/Source/Repo/Feedback/feedback.db";
        
            using var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM survey WHERE id = @id";
            using var cmd = new SQLiteCommand(stm,con);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            return new Survey(){ID=rdr.GetInt32(0),Lead1=rdr.GetInt32(1),Lead2=rdr.GetInt32(2),Lead3=rdr.GetInt32(3),Lead4=rdr.GetInt32(4),Lead5=rdr.GetInt32(5),Comm1=rdr.GetInt32(6),Comm2=rdr.GetInt32(7),Comm3=rdr.GetInt32(8),Comm4=rdr.GetInt32(9),Comm5=rdr.GetInt32(10),Tech1=rdr.GetInt32(11),Tech2=rdr.GetInt32(12),Tech3=rdr.GetInt32(13),Tech4=rdr.GetInt32(14),Tech5=rdr.GetInt32(15)};
        }
    }
    

 
}