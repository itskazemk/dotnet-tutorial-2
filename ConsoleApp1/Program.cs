using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ConsoleApp1;

class Program
{
    public class Computer
    {
        private string _motherBoard;
        public string MotherBoard
        {
            get { return _motherBoard; }
            set { _motherBoard = value; }
        }
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; }
    }

    static void Main(string[] args)
    {
        var computer = new Computer
        {
            MotherBoard = "motherbord",
            CPUCores = 1,
            HasWifi = true,
            HasLTE = false,
            ReleaseDate = DateTime.Now,
            Price = 100,
            VideoCard = "rtx 5060",
        };

        string connectionString =
            "Server=.;Database=DotNetCourseDatabase;User Id=sa;Password=1;TrustServerCertificate=true;Trusted_Connection=false;";

        IDbConnection dbConnection = new SqlConnection(connectionString);

        string query = "Select getdate()";

        var aa = dbConnection.Query<DateTime>(query);

        Console.WriteLine("Hello, World!");
    }
}
