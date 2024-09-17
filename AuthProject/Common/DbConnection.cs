using Microsoft.Data.SqlClient;
using System.Data;

namespace AuthProject.Common
{
    public class DbConnection
    {
        public static IDbConnection ConnectDb()
        {
            IDbConnection connection = new SqlConnection(GetConnectionString());
            return connection;
        }
        public static string GetConnectionString()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();
            var confingdata = config["ConnectionStrings:conn"];
            return confingdata;
        }
    }
}
