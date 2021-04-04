using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace DataAccess
{
  
        public abstract class ConnectionToSql
        {
            private readonly string connectionString;

            public ConnectionToSql()
            {
                connectionString = @"server=localhost;user id=root;password = 260601;persistsecurityinfo=True;database=ql_khach_san";
            }
            protected MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
             }
        }
    
}
