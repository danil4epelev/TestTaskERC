using System;

namespace TestTaskERC
{
    class Connection
    {
        private const string connectionString = @"Data Source=DESKTOP-EB1N23D;Initial Catalog=ERCData;Integrated Security=true";

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
    }
}
