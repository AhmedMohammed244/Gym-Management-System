using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gym_Management_System
{
    public class sqdbConnection : DBConnection
    {
        public override void OpenConnection()
        {
            Connection = new SqlConnection("Data Source = AR; Initial Catalog = Gym System DB; Integrated Security = True");
            Connection.Open();
        }

        public override void CloseConnection()
        {
            Connection.Close();
        }
    }
}
