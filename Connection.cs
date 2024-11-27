using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemoWindowsForm
{
    internal class Connection
    {
       public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\prajj\\source\\repos\\DatabaseDemoWindowsForm\\CollegeDb.mdf;Integrated Security=True");
        }        
    }
}
