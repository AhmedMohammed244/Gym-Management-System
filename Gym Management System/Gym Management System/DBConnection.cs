using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    public abstract class DBConnection
    {
        public SqlConnection Connection { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();


    }
}
