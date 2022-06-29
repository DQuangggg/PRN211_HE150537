using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace AutomobileLibrary.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvier dataProvier { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAL() {
            var connectionString = GetConnectionString();
            dataProvier = new StockDataProvier(connectionString);
        }

        public String GetConnectionString() {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }

        public void CloseConnection() => dataProvier.CloseConnection(connection);
    }
}
