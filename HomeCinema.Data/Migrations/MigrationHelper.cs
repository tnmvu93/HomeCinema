using System;
using System.IO;

namespace HomeCinema.Data.Migrations
{
    public class MigrationHelper
    {
        public static string ReadSqlFile(string name)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Migrations/" + name);
            return File.ReadAllText(sqlFile);
        }
    }
}
