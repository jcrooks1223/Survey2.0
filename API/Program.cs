using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Data.SQLite;
using API.Model;



namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
             string cs = @"URI=file:/Users/CrisReeves/Source/Repo/Feedback/feedback.db";
        

            using var con = new SQLiteConnection(cs);
             con.Open();
            ISeedData saveObj = new SaveData();
            saveObj.SeedData();
             
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
